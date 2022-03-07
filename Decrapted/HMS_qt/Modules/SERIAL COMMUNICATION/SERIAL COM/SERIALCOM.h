#ifndef SERIALCOM_H
#define SERIALCOM_H

#include <QMainWindow>
#include <serialcfg.h>
#include <dynamicchart.h>
#include <qplaintextedit.h>

namespace Ui {
class SERIALCOM;
}

class SERIALCOM : public QMainWindow
{
    Q_OBJECT

public:
    explicit SERIALCOM(QWidget *parent = nullptr);
    ~SERIALCOM();

private slots:

private:
    Ui::SERIALCOM *ui;

    SerialCfg* serialCfg;
    DynamicChart* curveChart;
};

#endif // SERIALCOM_H
