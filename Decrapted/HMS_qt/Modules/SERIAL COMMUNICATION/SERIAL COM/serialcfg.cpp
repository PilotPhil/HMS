#include "serialcfg.h"
#include "ui_serialcfg.h"

SerialCfg::SerialCfg(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::SerialCfg)
{
    ui->setupUi(this);

    serialPort=new QSerialPort(this);
    portNames=new QStringList;

    searchPorts();// 查找端口
    portOpenFlag=false;//端口标志置未打开
    receiveDataFlag=false;//接受数据标志设未打开接受


    //下拉框默认设置
    ui->CB_baudRate->setCurrentIndex(5);
    ui->CB_dataBit->setCurrentIndex(3);
    ui->CB_stopBit->setCurrentIndex(0);
    ui->CB_checkBit->setCurrentIndex(0);

    //表添加到预留widget中，并添加布局
    chart =new DynamicChart();
    QGridLayout *GL=new QGridLayout;
    ui->WG_chart->setLayout(GL);
    GL->addWidget(chart);

    //连接清理表格数据信号槽
    connect(this,SIGNAL(sigClearChart()),chart,SLOT(sltClearChart()));

}

SerialCfg::~SerialCfg()
{
    delete ui;
}

// 查找端口
void SerialCfg::searchPorts()
{
    portNames->clear();//清空端口名数组
    ui->CB_serialPort->clear();//情况下拉框中内容

    //遍历可用端口
    foreach(const QSerialPortInfo &info,QSerialPortInfo::availablePorts())
    {
        QString temp=info.portName()+"  "+info.description();//端口名+端口描述
        ui->CB_serialPort->addItem(temp);//下拉框增加元素
        qDebug()<<"可用串口及描述："<<temp;

        *portNames<<info.portName();//压入端口名列表
    } 
}

// 配置串口参数：端口，波特率，校验位，停止位，奇偶位
void SerialCfg::setSerial()
{
    // 设置端口
    serialPort->setPortName(portNames->at(ui->CB_serialPort->currentIndex()));

    // 设置波特率
    qint32 baud=ui->CB_baudRate->currentText().toInt();
    serialPort->setBaudRate(baud);

    // 设置数据位，构造vector类容器，根据下拉框的index配置参数
    QVector<QSerialPort::DataBits> db={QSerialPort::Data5,QSerialPort::Data6,QSerialPort::Data7,QSerialPort::Data8};
    serialPort->setDataBits(db.at(ui->CB_dataBit->currentIndex()));

    // 设置校验位
    QVector<QSerialPort::Parity> ck={QSerialPort::NoParity,QSerialPort::EvenParity,QSerialPort::MarkParity,QSerialPort::OddParity};
    serialPort->setParity(ck.at(ui->CB_checkBit->currentIndex()));

    // 设置停止位
    QVector<QSerialPort::StopBits> st={QSerialPort::OneStop,QSerialPort::OneAndHalfStop,QSerialPort::TwoStop,QSerialPort::UnknownStopBits};
    serialPort->setStopBits(st.at(ui->CB_stopBit->currentIndex()));
}

// 打开串口
bool SerialCfg::openPort()
{
    if(serialPort->isOpen())
    {
        serialPort->clear();//清空串口缓存
        serialPort->close();//关闭串口
    }

    setSerial();// 配置串口参数：端口，波特率，校验位，停止位，奇偶位

    if(serialPort->open(QIODevice::ReadWrite)==true)//以读写方式打开串口，成功返回true
    {
        qDebug()<<"串口打开成功";
        ui->PB_openSerial->setText("关闭串口");//串口打开成功才更改按钮上显示文字
        portOpenFlag=true;//串口标志为置真
        return true;//返回打开成功true
    }
    else
    {
        qDebug()<<"串口打开失败";
        return false;
    }
}

// 关闭串口
void SerialCfg::closePort()
{
    serialPort->clear();
    serialPort->close();
    qDebug()<<"串口已关闭";
    ui->PB_openSerial->setText("打开串口");
    portOpenFlag=false;
}

// 读取数据
void SerialCfg::readData()
{
    QString msg=serialPort->readLine();
    data=data+msg;
    ui->PT_showData->setPlainText(data);
    ui->PT_showData->moveCursor(QTextCursor::End);//滚动条自动滚动到最底部
    ui->PT_showData->setVerticalScrollBarPolicy(Qt::ScrollBarAlwaysOff);//隐藏滚动条

    qDebug()<<"串口数据："<<msg;

    //emit sendSerialData(msg.toDouble());//发送数据信号
    if(ui->CHB_isDraw->isChecked()==true)
    {
        chart->ScrollDraw(msg.toDouble());
    }

}

//开关槽函数
void SerialCfg::on_PB_openSerial_clicked()
{
    qDebug()<<"开关串口按钮被按下";

    if(portOpenFlag==false)
    {
        openPort();
    }
    else
    {
        closePort();
        receiveDataFlag=false;
    }
}

//发送数据槽函数
void SerialCfg::on_PB_sendSerialData_clicked()
{
    if(serialPort->isOpen()==true)
    {
        qDebug()<<"发送数据";
        QByteArray sendData=ui->PT_sendData->toPlainText().toUtf8();
        serialPort->write(sendData);
    }
}

//接受数据按钮
void SerialCfg::on_PB_receiveData_clicked()
{
    receiveDataFlag=!receiveDataFlag;//标志位取反，开关效果

    if(receiveDataFlag==true)
    {
        //串口读取信号链接
        connect(serialPort,&QSerialPort::readyRead,this,&SerialCfg::readData);
        ui->PB_receiveData->setText("关闭接收");
    }
    else
    {
        disconnect(serialPort,&QSerialPort::readyRead,this,&SerialCfg::readData);
        ui->PB_receiveData->setText("接收数据");
    }

}

//清空图表槽函数
void SerialCfg::on_PB_clearChart_clicked()
{
    emit sigClearChart();
}
