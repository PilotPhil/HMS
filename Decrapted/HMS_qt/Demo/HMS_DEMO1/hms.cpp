#include "hms.h"
#include "ui_hms.h"

HMS::HMS(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::HMS)
{
    ui->setupUi(this);

    /***********查看现在可用的数据库驱动***********/
    qDebug() << "Available drivers:";
    QStringList drivers = QSqlDatabase::drivers();
    foreach(QString driver, drivers)
    qDebug() << "/t" << driver;
    /******************************************/

    db=DATABASE::dbInstance(this);//数据库
    db->dbInit();

    udpui=new UDPUI(this);
    QGridLayout * GL0=new QGridLayout(this);//将表格添加入stackwidget
    ui->widget_UDP->setLayout(GL0);
    GL0->addWidget(udpui);

    serialCom=new SerialCfg(this);
    QGridLayout * GL1=new QGridLayout(this);//将表格添加入stackwidget
    ui->widget_serial->setLayout(GL1);
    GL1->addWidget(serialCom);

    QStringList sensorTableHeads;
    sensorTableHeads<<"序号"<<"类型"<<"命名"<<"位置"<<"是否启用"<<"初始值"<<"单位"<<"原始数据";

    sensorTable=new SQL_TABLE(this,"SENSOR");//选择数据库中的sensor这张表格
    sensorTable->setHorizontalHeaders(sensorTableHeads);//设置横向表头
    QGridLayout * GL2=new QGridLayout(this);//将表格添加入stackwidget
    ui->widget_sensorCfg->setLayout(GL2);
    GL2->addWidget(sensorTable);

    ui->stackedWidget->widget(0)->layout()->setContentsMargins(0,0,0,0);//stackwidget去掉边缘空白
    ui->stackedWidget->widget(1)->layout()->setContentsMargins(0,0,0,0);

    ui->widget_UDP->layout()->setContentsMargins(0,0,0,0);//去掉边缘空白
    ui->widget_serial->layout()->setContentsMargins(0,0,0,0);//去掉边缘空白
    ui->widget_sensorCfg->layout()->setContentsMargins(0,0,0,0);//去掉边缘空白
}

HMS::~HMS()
{
    delete ui;
}


void HMS::on_pushButton_edit_clicked()
{
    SENSORCONFIG * sc=new SENSORCONFIG(this);
    sc->show();
    qDebug()<<sc;

}


void HMS::on_pushButton_useUdp_clicked()
{
    ui->widget_serial->setDisabled(true);
    ui->widget_UDP->setEnabled(true);

    ui->pushButton_useUdp->setChecked(true);
    ui->pushButton_useSerial->setChecked(false);
}

void HMS::on_pushButton_useSerial_clicked()
{
    ui->widget_UDP->setDisabled(true);
    ui->widget_serial->setEnabled(true);

    ui->pushButton_useSerial->setChecked(true);
    ui->pushButton_useUdp->setChecked(false);
}
