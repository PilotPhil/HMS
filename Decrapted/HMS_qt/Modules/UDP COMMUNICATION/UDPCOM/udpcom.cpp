#include "udpcom.h"
#include "ui_udpcom.h"

UDPCOM::UDPCOM(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::UDPCOM)
{
    ui->setupUi(this);

    udp=MYUDP::Instance(this);

    QString localIP=udp->getLocalIp();//获取本地ip
    this->setWindowTitle("UDP COM通信");

    ui->comboBox_targetIP->addItem(localIP);//添加

    ui->label_socketState->setText("Socket状态：");

    connect(udp,&MYUDP::sendSocketMsg,this,&UDPCOM::disp);//

    ui->textEdit_disp->setReadOnly(true);//设置不可编辑
}

UDPCOM::~UDPCOM()
{
    delete ui;
}

/*---------------------显示区域更新---------------------*/
void UDPCOM::disp(QString msg)
{
    ui->textEdit_disp->append(msg);//显示区域增加收到的信息
}

/*---------------------绑定按钮---------------------*/
void UDPCOM::on_pushButton_bindPort_clicked()
{
    quint16 port=quint16(ui->spinBox_bindPort->value());//显示转化，强制转换

    if(udp->bindPort(port)==true)//绑定成功返true
    {
        ui->textEdit_disp->append("已绑定端口");

        ui->label_socketState->setText("Socket状态：已绑定");
    }
    else
    {
        ui->textEdit_disp->append("绑定端口失败");
        ui->label_socketState->setText("Socket状态：绑定失败");
    }
}

/*---------------------解绑按钮---------------------*/
void UDPCOM::on_pushButton_abortBind_clicked()
{
    udp->abortPort();//解绑
    ui->textEdit_disp->append("已解绑端口");
    ui->label_socketState->setText("Socket状态：未绑定");
}

/*---------------------发送消息(点对点)---------------------*/
void UDPCOM::on_pushButton_sendP2P_clicked()
{
    if(ui->lineEdit_msg2Send->text().count()==0)
    {
        return;
    }
    QString str=ui->lineEdit_name->text()+": "+ui->lineEdit_msg2Send->text();

    ui->textEdit_disp->append(str);

    QByteArray msg=str.toUtf8();//要发送的信息 转为utf8

    QHostAddress targetIp(ui->comboBox_targetIP->currentText());//目标Ip

    quint16 targetPort=quint16 (ui->spinBox_targetPort->value());//目标端口

    udp->sendMsgp2p(msg,targetIp,targetPort);//发送

    ui->lineEdit_msg2Send->clear();
    ui->lineEdit_msg2Send->setFocus();
}

/*---------------------广播消息---------------------*/
void UDPCOM::on_pushButton_Broadcast_clicked()
{  
    if(ui->lineEdit_msg2Send->text().count()==0)
    {
        return;
    }

    QString str=ui->lineEdit_name->text()+": "+ui->lineEdit_msg2Send->text();

    ui->textEdit_disp->append(str);

    QByteArray msg=str.toUtf8();//要发送的信息 转为utf8

    ui->textEdit_disp->append(ui->lineEdit_name->text()+": "+msg);

    quint16 targetPort=quint16 (ui->spinBox_targetPort->value());//目标端口

    udp->sendMsgBroadcast(msg,targetPort);//广播

    ui->lineEdit_msg2Send->clear();
    ui->lineEdit_msg2Send->setFocus();
}

/*---------------------清空显示区域---------------------*/
void UDPCOM::on_pushButton_clearDisp_clicked()
{
    ui->textEdit_disp->clear();
}
