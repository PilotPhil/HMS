#include "visualdevicedriver.h"
#include "ui_visualdevicedriver.h"

#include "ADS1256/ADS1256.h"
#include <QDebug>

VisualDeviceDriver::VisualDeviceDriver(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::VisualDeviceDriver)
{
    ui->setupUi(this);

    //ADC
    adcForm=new AdcForm(this);
    QGridLayout *ly=new QGridLayout(this);
    ui->wgt_adsSettings->setLayout(ly);
    ly->addWidget(adcForm);

    //Serial
    serial=new SerialCfg(this);
    QGridLayout *ly1=new QGridLayout(this);
    ui->wgt_serial->setLayout(ly1);
    ly1->addWidget(serial);
}

VisualDeviceDriver::~VisualDeviceDriver()
{
    delete ui;
}
