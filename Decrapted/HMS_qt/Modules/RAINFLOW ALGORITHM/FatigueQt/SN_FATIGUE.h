#ifndef RAINFLOW_H
#define RAINFLOW_H

#include <QObject>
#include <QDebug>
#include <QVector>
#include <algorithm>
#include <QQueue>
#include <QPointF>
#include <qmath.h>

typedef QVector<double> DF;//在此类中常用的数据型别 data format

/*---------------------rainflow data---------------------*/
class RData:public QObject//定义的数据结构 rainflow data
{
    Q_OBJECT
public:
    explicit RData(QObject *parent = nullptr);

    DF * index;    //索引
    DF * range;    //幅值
    DF * mean;     //均值
    DF * count;    //计数
    DF * start;    //起始点
    DF * end;      //终止点

    void clearAllMember();
    void debugAllMember();
};

/*---------------------RAINFLOW---------------------*/
class RAINFLOW : public QObject
{
    Q_OBJECT
private:
    RData *RD;                                                          //rainflow data
    void FormatOutput(const double point1,
                      const double point2,
                      const double cot,
                      const double st,
                      const double ed);//格式化输出,禁止修改参数

public:
    explicit RAINFLOW(QObject *parent = nullptr);
    DF * KeepPeaksAndValleys(DF &ser);                                  //提取峰谷,可修改参数，修改后参数即为peakvally
    RData * ExtractCycles(DF &series);                                    //提取循环,禁止修改参数
};

/*---------------------DAMAGE---------------------*/
class DAMAGE:public QObject
{
    Q_OBJECT
 private:
    double K;                       //系数
    double UltraStress;             //屈服应力
    DF * meanStress;                //平均应力
    double damage;                  //损伤度

public:
    explicit DAMAGE(QObject *parent = nullptr);
    void SetKValue(double K){this->K=K;}                            //设置K值
    void SetUltraStress(double U){this->UltraStress=U;}             //设置屈服应力

    void MeanStressCorrection(const DF & range,const DF & mean);    //平均应力修正
    double DamageCompute();                                           //计算损伤

};

#endif // FATIGUE_RAINFLOW_H
