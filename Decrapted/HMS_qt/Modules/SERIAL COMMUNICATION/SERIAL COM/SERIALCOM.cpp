#include "SERIALCOM.h"
#include "ui_SERIALCOM.h"

SERIALCOM::SERIALCOM(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::SERIALCOM)
{
    ui->setupUi(this);

    this->setWindowTitle("PILOT串口调试助手");

    serialCfg =new SerialCfg();//实例一个串口通信
    QGridLayout *GL=new QGridLayout;
    ui->widget->setLayout(GL);
    GL->addWidget(serialCfg);



}

SERIALCOM::~SERIALCOM()
{
    delete ui;
}

