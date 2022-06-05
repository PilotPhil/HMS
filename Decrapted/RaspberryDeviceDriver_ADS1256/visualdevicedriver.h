#ifndef VISUALDEVICEDRIVER_H
#define VISUALDEVICEDRIVER_H

#include <QWidget>
#include <QGridLayout>

#include "adcform.h"
#include "Serial/serialcfg.h"

QT_BEGIN_NAMESPACE
namespace Ui { class VisualDeviceDriver; }
QT_END_NAMESPACE

class VisualDeviceDriver : public QWidget
{
    Q_OBJECT

public:
    VisualDeviceDriver(QWidget *parent = nullptr);
    ~VisualDeviceDriver();

private slots:

private:
    Ui::VisualDeviceDriver *ui;

    AdcForm *adcForm;
    SerialCfg *serial;
};
#endif // VISUALDEVICEDRIVER_H
