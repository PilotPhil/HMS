#include "fatigue.h"
#include "ui_fatigue.h"

FATIGUE::FATIGUE(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::FATIGUE)
{
    ui->setupUi(this);

    //普通成员
    data=new DF;
    peakVally=new DF;

    //雨流法
    rf=new RAINFLOW(this);
    rd=new RData(this);
    DM=new DAMAGE;

    //表
    myChart=new MYCHART();
    QGridLayout *GL=new QGridLayout;
    ui->WG_chart->setLayout(GL);
    GL->addWidget(myChart);

    //表中 线
    rawDataSeries=new QLineSeries;
    peakVallySeries=new QLineSeries;

    //表格
    myTable=new MYTABLE();
    QGridLayout *GL2=new QGridLayout;
    ui->WG_table->setLayout(GL2);
    GL2->addWidget(myTable);

    //读取CSV
    readCsv=new DOCSV;

    //所有信号与槽链接
    allConnect();

    //加载样式表
    loadQSS();
}

FATIGUE::~FATIGUE()
{
    delete ui;
}

/*----------------------------逻辑说明-------------------------------*/
/*
 * 点击按钮 触发信号clicked——>文件夹弹窗选取csv文件名——>发送给读取csv文件内容
 *          ——>csv文件内容——>process总处理函数——>rainflow处理函数
 *          ——>发送index、peakVally——>接收后构成折线序列——>交折线表显示
 *          ——>发送count、range、start...——>接收后发给表格显示
 */
/*----------------------------逻辑说明-------------------------------*/


/*----------------------------所有信号与槽链接-------------------------------*/
void FATIGUE::allConnect()
{
    //接受多个数据，成员拷贝其元素
    connect(this,&FATIGUE::sendKValues,DM,&DAMAGE::SetKValue);//K值的发送与接收
    connect(this,&FATIGUE::sendUltraStress,DM,&DAMAGE::SetUltraStress);//屈服应力的发送与接收

    connect(this,&FATIGUE::sendAll2Table,myTable,&MYTABLE::UpdateTable);//发送所有数据到表格显示

    connect(this,&FATIGUE::sendCsvFileName,readCsv,&DOCSV::receiveFileNameRead);//发送选取的文件名
    connect(readCsv,&DOCSV::sendCsvData,this,&FATIGUE::receiveCsvData);//接受csv读取的数据
}

/*----------------------------加载样式表-------------------------------*/
void FATIGUE::loadQSS()
{
//    QFile qssFile(":/AMOLED.qss");
    QFile qssFile(":/Aqua.qss");
//    QFile qssFile(":/MacOS.qss");
//    QFile qssFile(":/Ubuntu.qss");
    qssFile.open(QFile::ReadOnly);

    if(qssFile.isOpen())
    {
        QString qss = QLatin1String(qssFile.readAll()); //读取
        qApp->setStyleSheet(qss);  //设置
        qssFile.close();//记得关闭文件
    }
}

/*----------------------------总处理槽函数-------------------------------*/
void FATIGUE::process(DF y)//读取csv数据后，发信号传递读取到的数据，调用此处理函数
{
    //调用前 先清楚 防止第二次调用时，成员中元素残留造成的表格画面残留
    this->rawDataSeries->clear();
    this->data->clear();

    data->append(y);

    rawDataSeries=myChart->myMakeSeries(y);//制造表中折线序列

    DF *id=rf->KeepPeaksAndValleys(*data);

    peakVallySeries=myChart->myMakeSeries(*id,*data);
    myChart->myAdjustAxis(*data);//自动调整坐标轴长度

    RData * RD=rf->ExtractCycles(*data);

    emit sendAll2Table(*RD->count,*RD->range,*RD->mean,*RD->start,*RD->end);

    DM->MeanStressCorrection(*RD->range,*RD->mean);
    double damage=DM->DamageCompute();

    ui->LE_damage->setText(QString::number(damage*100,'f')+"%");
    qDebug()<<damage;

    delete RD;
    delete id;
}

void FATIGUE::receiveCsvData(DF data)//接收读取csv得到的数据
{
    process(data);
}

/*----------------------------生成的槽函数-------------------------------*/
void FATIGUE::on_CB_rawData_clicked(bool checked)
{
    if(checked==true)
        myChart->myAddSeries(rawDataSeries);
    else
        myChart->myRemoveSeries(rawDataSeries);
}

void FATIGUE::on_CB_peakVally_clicked(bool checked)
{
    if(checked==true)
        myChart->myAddSeries(peakVallySeries);
    else
        myChart->myRemoveSeries(peakVallySeries);
}

void FATIGUE::on_PB_inputData_clicked()
{
    QFileDialog * fd = new QFileDialog();//创建打开文件对话框
    QString fileName = fd->getOpenFileName(this,tr("Open File"),"/home",tr("Excel(*.csv)"));

    if(fileName!="")
    {
        sendCsvFileName(fileName);
        ui->LE_address->setText(fileName);
    }
}

void FATIGUE::receiveRData(RData *rd)
{
    this->rd->index->clear();//接受前先清空，避免二次调用的残留
    this->rd->index->append(*rd->index);//复制形参元素到成员

    this->rd->range->clear();//接收前先清空，避免二次调用的残留
    this->rd->range->append(*rd->range);//复制形参元素到成员

    this->rd->mean->clear();//接收前先清空，避免二次调用的残留
    this->rd->mean->append(*rd->mean);//复制形参元素到成员

    this->rd->count->clear();//接收前先清空，避免二次调用的残留
    this->rd->count->append(*rd->count);//复制形参元素到成员

    this->rd->start->clear();//接收前先清空，避免二次调用的残留
    this->rd->start->append(*rd->start);//复制形参元素到成员

    this->rd->end->clear();//接收前先清空，避免二次调用的残留
    this->rd->end->append(*rd->end);//复制形参元素到成员

    //end最后一个发出信号并接收，此接收后，将上述所有接收的发送给表格
    sendAll2Table(*this->rd->count,*this->rd->range,*this->rd->mean,
                  *this->rd->start,*this->rd->end);//区别形参与私有成员
}



void FATIGUE::on_comboBox_currentIndexChanged(int index)
{
    double K=0;
    switch (index)
    {
    case 0:K=5.8E12;break;
    case 1:K=3.46E12;break;
    case 2:K=1.52E12;break;
    case 3:K=1.026E12;break;
    case 4:K=6.319E11;break;
    case 5:K=4.33E11;break;
    case 6:K=2.48E11;break;
    case 7:K=9.279E10;break;
    }

    sendKValues(K);
}

void FATIGUE::on_doubleSpinBox_valueChanged(double arg1)
{
    sendUltraStress(arg1);
}

void FATIGUE::on_PB_reCompute_clicked()
{
//    rf->RainFlow(*data);//雨流计数
}
