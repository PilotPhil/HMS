#include "udpui.h"
#include "ui_udpui.h"

UDPUI::UDPUI(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::UDPUI)
{
    ui->setupUi(this);

    udp=MYUDP::Instance(this);

    QString localIP=udp->getLocalIp();//获取本地ip

    ui->comboBox_targetIp->addItem(localIP);//添加

    connect(udp,&MYUDP::sendSocketMsg,this,&UDPUI::disp);//

    ui->textEdit_receivedMsg->setReadOnly(true);//设置不可编辑
}

UDPUI::~UDPUI()
{
    delete ui;
}

void UDPUI::disp(QString &msg)
{
    if(ui->checkBox_dispReceive->checkState()==false)
    {
        return;
    }
    ui->textEdit_receivedMsg->append(msg);//显示区域增加收到的信息
}


/*---------------------发送消息(点对点)---------------------*/
void UDPUI::on_pushButton_send_clicked()
{
    if(ui->textEdit_msg2send->toPlainText().count()==0)
    {
        return;
    }
    QString str=ui->textEdit_msg2send->toPlainText();

    QByteArray msg=str.toUtf8();//要发送的信息 转为utf8

    QHostAddress targetIp(ui->comboBox_targetIp->currentText());//目标Ip

    quint16 targetPort=quint16 (ui->spinBox_targetPort->value());//目标端口

    udp->sendMsgp2p(msg,targetIp,targetPort);//发送

    ui->textEdit_msg2send->clear();
    ui->textEdit_msg2send->setFocus();
}

/*---------------------清空显示区域---------------------*/
void UDPUI::on_pushButton_clearDisp_clicked()
{
    ui->textEdit_receivedMsg->clear();
}

void UDPUI::on_pushButton_bindorAbort_clicked()
{
    if(ui->pushButton_bindorAbort->isChecked()==true)
    {
        quint16 port=quint16(ui->spinBox_localPort->value());//显示转化，强制转换

        if(udp->bindPort(port)==true)//绑定成功返true
        {
            ui->label_socketState->setText(QString("Socket 状态:已绑定端口(%1)").arg(port));
        }
        else
        {
            ui->label_socketState->setText("Socket 状态:绑定失败");
            QMessageBox::warning(nullptr,"警告","端口绑定失败，请检查参数，查看端口是否被占用",QMessageBox::Ok,QMessageBox::NoButton);
        }
    }
    else
    {
        udp->abortPort();//解绑
        ui->label_socketState->setText("Socket 状态:已解绑");
    }
}
