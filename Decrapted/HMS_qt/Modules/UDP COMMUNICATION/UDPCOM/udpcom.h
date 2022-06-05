#ifndef UDPCOM_H
#define UDPCOM_H

/*
 *@Name:    UDPCOM
 *@Auth:    Pilot.Phil
 *@Data:    2021-3-6
 *@Decp:    UDP通信主界面与逻辑
 */


#include <QWidget>
#include "myudp.h"

namespace Ui {
class UDPCOM;
}

class UDPCOM : public QWidget
{
    Q_OBJECT

private:
    Ui::UDPCOM *ui;

    MYUDP *udp;//

private slots:
    void on_pushButton_bindPort_clicked();

    void on_pushButton_abortBind_clicked();

    void on_pushButton_sendP2P_clicked();

    void on_pushButton_Broadcast_clicked();

    void on_pushButton_clearDisp_clicked();

public:
    explicit UDPCOM(QWidget *parent = nullptr);
    ~UDPCOM();

public slots:
    void disp(QString msg);

};

#endif // UDPCOM_H
