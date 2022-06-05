#ifndef MYUDP_H
#define MYUDP_H

/*
 *@Name:    MYUDP
 *@Auth:    Pilot.Phil
 *@Data:    2021-3-6
 *@Decp:    封装的UDP通信类
 */

/*
UDP(User Datagram Protocol,用户数据报协议)是轻量的、不可靠的、面向数据报、无连接的协议，用于对可靠性要求不高的场合。
进行UDP数据收发，先用bind()函数绑定端口，当有数据传入时，会发射readyRead()信号，使用readDatagram()接收，使用writeDatagram()向指定端口发送。
发送分为单播、广播、组播模式，所使用的发送函数不同。

在同一台计算机上运行时，需运行两个应用实例，绑定对方的端口即可通信，端口不可相同。
在不同计算机上运行时，可以使用相同端口，因为IP地址不同。
*/

/*
 * 设计模式：SingleTon 单例模式
 * 重构原因：因为只有一个UDP数据源
 * 使用：MYUDP *udp=MYUDP::Instance();
 *      udp.bind();
 *      MYUDP::Instance().bind();
 * 备注：此为线程非安全版，不要在多线程中应用，确保一个应用只需要一个udp数据来源
 * 重构日期：2021-3-9
 */

#include <QObject>
#include<QUdpSocket>
#include <QHostAddress>
#include <QNetworkInterface>


class MYUDP : public QObject
{
    Q_OBJECT

private:
    static MYUDP * _instance;//

    QUdpSocket *udpSocket;//用于UDP通信的socket

protected:
    explicit MYUDP(QObject *parent = nullptr);//将构造函数写为受保护的，防止实例化多个对象。

public:
    static MYUDP * Instance(QObject *parent=nullptr);//使用Instance成员函数返回唯一的实例

    QString getLocalIp();//获取本机ip

    bool bindPort(quint16 &port);//绑定端口

    void abortPort();//解除绑定

    void sendMsgp2p(QByteArray &msg,QHostAddress &targetIp,quint16 targetPort);//发送消息(点对点)

    void sendMsgBroadcast(QByteArray &msg,quint16 targetPort);//发送消息(广播)

    void readSocket();//读取


signals:
    void sendSocketMsg(QString &msg);//发送socket信息信号


};

#endif // MYUDP_H
