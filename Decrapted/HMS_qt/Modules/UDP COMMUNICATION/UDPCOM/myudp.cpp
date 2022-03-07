#include "myudp.h"

MYUDP::MYUDP(QObject *parent) : QObject(parent)
{
    udpSocket=new QUdpSocket(this);

    connect(udpSocket,&QUdpSocket::readyRead,this,&MYUDP::readSocket);
}

MYUDP * MYUDP::_instance=nullptr;//静态成员变量在类外定义

MYUDP *MYUDP::Instance(QObject *parent)//
{
    if(_instance==nullptr)
    {
        _instance=new MYUDP(parent);
        qDebug()<<"创建了唯一的一个UDP通信";
    }
    return _instance;//返回创建的UDP通信
}

/*---------------------获取本机地址---------------------*/
QString MYUDP::getLocalIp()
{
    QList<QHostAddress> ipAddressesList = QNetworkInterface::allAddresses();
    QString mIpAddress;
    // use the first non-localhost IPv4 address
    for (int i = 0; i < ipAddressesList.size(); ++i)
    {
        if (ipAddressesList.at(i) != QHostAddress::LocalHost &&ipAddressesList.at(i).toIPv4Address())
        {
            mIpAddress = ipAddressesList.at(i).toString();
            break;
        }
    }
    // if we did not find one, use IPv4 localhost
    if (mIpAddress.isEmpty())
        mIpAddress = QHostAddress(QHostAddress::LocalHost).toString();
    return mIpAddress;//获取本机正在使用的IP地址
}

/*---------------------绑定端口---------------------*/
bool MYUDP::bindPort(quint16 &port)
{
    return(udpSocket->bind(port));//绑定端口
}

/*---------------------解除绑定---------------------*/
void MYUDP::abortPort()
{
    udpSocket->abort();//解除绑定
}

/*---------------------点对点发送---------------------*/
void MYUDP::sendMsgp2p(QByteArray &msg,QHostAddress &targetIp,quint16 targetPort)
{
    udpSocket->writeDatagram(msg,targetIp,targetPort);//发出数据报
}

/*---------------------广播发送---------------------*/
void MYUDP::sendMsgBroadcast(QByteArray &msg, quint16 targetPort)
{
    udpSocket->writeDatagram(msg,QHostAddress::Broadcast,targetPort);//QHostAddress::Broadcast广播用地址一般为255.255.255.255
}

/*---------------------读取socket消息---------------------*/
void MYUDP::readSocket()
{
    while (udpSocket->hasPendingDatagrams())
    {
        QByteArray datagram;
        datagram.resize(int(udpSocket->pendingDatagramSize()));

        QHostAddress peerAddr;
        quint16 peerPort;
        udpSocket->readDatagram(datagram.data(),datagram.size(),&peerAddr,&peerPort);
        QString str=datagram.data();

        QString peer="[FROM "+peerAddr.toString()+":"+QString::number(peerPort)+"]:"+str;

        sendSocketMsg(str);

//        return peer;
    }
}



