#ifndef UDPUI_H
#define UDPUI_H

#include <QWidget>
#include <QString>
#include <QHostAddress>
#include <QNetworkInterface>
#include <QMessageBox>

#include "myudp.h"

namespace Ui {
class UDPUI;
}

class UDPUI : public QWidget
{
    Q_OBJECT

public:
    explicit UDPUI(QWidget *parent = nullptr);
    ~UDPUI();

    void disp(QString &msg);

private slots:
    void on_pushButton_send_clicked();

    void on_pushButton_clearDisp_clicked();

    void on_pushButton_bindorAbort_clicked();

private:
    Ui::UDPUI *ui;

    MYUDP *udp;
};

#endif // UDPUI_H
