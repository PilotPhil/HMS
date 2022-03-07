#include "SN_FATIGUE.h"

//    qRegisterMetaType<RData>("RData");

/*---------------------RData---------------------*/
RData::RData(QObject *parent):QObject (parent)
{
    index=new DF;
    range=new DF;
    mean=new DF;
    count=new DF;
    start=new DF;
    end=new DF;
}

void RData::clearAllMember()
{
    index->clear();
    range->clear();
    mean->clear();
    count->clear();
    start->clear();
    end->clear();
}

void RData::debugAllMember()
{
    qDebug()<<"range:"<<range;
    qDebug()<<"mean:"<<mean;
    qDebug()<<"count:"<<count;
    qDebug()<<"start:"<<start;
    qDebug()<<"end:"<<end;
}

/*---------------------RAINFLOW---------------------*/
RAINFLOW::RAINFLOW(QObject *parent) : QObject(parent)
{
    RD=new RData(this);
}

//提取峰谷
DF * RAINFLOW::KeepPeaksAndValleys(DF &series)
{
    int id=1;
    RD->index->append(0);//索引
    int lt=int(series.size());//获取序列原始长度

    for(auto it=series.begin()+1;it<series.end()-1;++it)//从1开始判断，并非0，因为0 1 2 才构成判断峰谷的序列长度条件。并到倒数第二结束判断
    {
        auto isPeak=*it>*(it-1) && *it>*(it+1);     //判断是否为峰：it-1<it>it+1
        auto isValley=*it<*(it-1) && *it<*(it+1);   //判断是否为谷：it-1>it<it+1

        if(isPeak==false && isValley==false)        //非峰非谷 擦除此点
        {
            series.erase(it);//对参数series进行了删改
            it--;
        }
        else                                        //否则索引添加，添加的是原始未删减序列中元素的标号
        {
            RD->index->append(id);
        }
        id++;
    }

    RD->index->append(lt-1);

    qDebug()<<"IN KeepPeaksAndValleys::index--->"<<*RD->index;
    qDebug()<<"IN KeepPeaksAndValleys::series--->"<<series;

    return RD->index;
}

//提取循环重载，带有起始终值点输出
RData * RAINFLOW::ExtractCycles(DF &series)
{
    QQueue<double> points;
    QQueue<double> id;

    for(int i=0;i<series.length();i++)//在此循环中，利用points逐个元素拷贝series，并没有对series做出改动，所以使用引用传递是安全的
    {
        points.append(series.at(i));//拷贝峰谷点到双向序列中
        id.append(RD->index->at(i));

        while(points.length()>=3)//序列长度大于等于3就一直运行
        {
            double x1=points.at(points.length()-3);//获取序列中三个点（倒数：因为上面append是往后面添加）
            double x2=points.at(points.length()-2);
            double x3=points.at(points.length()-1);

            double X=qAbs(x3-x2);//幅值绝对值
            double Y=qAbs(x2-x1);//幅值绝对值

            if (X<Y)//是否构成循环？
            {
                break;
            }
            else if (points.length()==3)
            {
                //Y include Z
                //yes:
                //1.count Y as 1/2 cycle
                //2.discard the first reversal of Y
                //3.set Z to the second reversal of Y

                FormatOutput(points.at(0),points.at(1),0.5,id.at(0),id.at(1));//1/2 cycle，只有三个点，索引用0 1 即可
                points.dequeue();//Removes the head item in the queue
                id.dequeue();//Removes the head item in the queue
            }
            else
            {
                //Y include Z
                //no:
                //1.count Y as 1 cycle
                //2.discard both points of Y

                FormatOutput(points.at(points.length()-3),points.at(points.length()-2),1.0,
                             id.at(points.length()-3),id.at(points.length()-2));
                double last=points.at(points.length()-1);//先保存最后一个点
                points.pop_back();//删除末尾三个点
                points.pop_back();
                points.pop_back();
                points.append(last);//添加最后一个点

                double last2=id.at(id.length()-1);
                id.pop_back();
                id.pop_back();
                id.pop_back();
                id.append(last2);
            }
        }
    }
    while(points.length()>1)//做完上述循环后，序列长度肯定小于等于3
    {
        FormatOutput(points.at(0),points.at(1),0.5,id.at(0),id.at(1));
        points.dequeue();//Removes the head item in the queue
        id.dequeue();//Removes the head item in the queue
    }

    return RD;
}

//格式化输出
void RAINFLOW::FormatOutput(const double point1,const double point2,
                            const double cot,const double st,const double ed)
{
    RD->range->append(abs(point1-point2));      //添加幅值
    RD->mean->append((point1+point2)*0.5);      //添加均值
    RD->count->append(cot);                     //添加计数
    RD->start->append(st);                      //添加开始点
    RD->end->append(ed);                        //添加结束点
}

/*---------------------DAMAGE---------------------*/
//DAMAGE构造
DAMAGE::DAMAGE(QObject *parent) : QObject(parent)
{
    meanStress=new DF;
    K=5.8e12;
    UltraStress=235;
    damage=0;
}

//平均应力修正
void DAMAGE::MeanStressCorrection(const DF &range, const DF &mean)
{
    meanStress->clear();

    for(int i=0;i<range.count();i++)
        meanStress->append((2*UltraStress*range.at(i))/(UltraStress-mean.at(i)));
}

//计算损伤
double DAMAGE::DamageCompute()
{
    damage=0;//先归零

    foreach(double m,*meanStress)
    {
        damage+=1/pow(10,log10(K)-3*log10(m));
    }

    qDebug()<<"damage:"<<damage;

    return damage;
}

/*
应当构造数据处理流程
伪代码：
DF * series=new DF;

saveRawData2DB(series);//保存原始数据

lowPass(series);//使用低通滤波器

calculateMean(series);//计算均值

calculateStd();//计算标准差

calculateZeroCross();//计算平均跨零率

//开始进入雨流计数法

KeepPeaksAndValleys(series);//提取峰谷，引用传递，会删改rawdata

savePeakVally2DB(series);//保存峰谷点

RData * RD=ExtractCycles(series);//此时会写入rainflow中的成员变量RD内，会返回RD的地址

开始计算损伤

MeanStressCorrection(RD->range,RD->mean);//写入DAMAGE类内的成员变量

DamageCompute();//返回损伤度

*/
