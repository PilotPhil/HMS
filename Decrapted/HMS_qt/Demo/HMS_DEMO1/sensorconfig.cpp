#include "sensorconfig.h"
#include "ui_sensorconfig.h"

SENSORCONFIG::SENSORCONFIG(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::SENSORCONFIG)
{
    ui->setupUi(this);

    //
    rawDataFlag=false;
    meanFlag=false;
    stdFlag=false;
    zeroCrossFlag=false;
    peakVallyDetectFlag=false;
    rainflowFlag=false;
    damageComputeFlag=false;
    lowPassFlag=false;
    highPassFlag=false;

    unit="uStrain";

    this->setWindowTitle("传感器配置");

    allConnect();
}

SENSORCONFIG::~SENSORCONFIG()
{
    delete ui;
}

void SENSORCONFIG::allConnect()
{
    //checkbox信号与槽链接
    connect(ui->cb_rawData,&QCheckBox::stateChanged,[=]() mutable{rawDataFlag=!rawDataFlag;});
    connect(ui->cb_mean,&QCheckBox::stateChanged,[=]() mutable{meanFlag=!meanFlag;});
    connect(ui->cb_std,&QCheckBox::stateChanged,[=]() mutable{stdFlag=!stdFlag;});
    connect(ui->cb_zeroCross,&QCheckBox::stateChanged,[=]() mutable{zeroCrossFlag=!zeroCrossFlag;});
    connect(ui->cb_peakVally,&QCheckBox::stateChanged,[=]() mutable{peakVallyDetectFlag=!peakVallyDetectFlag;});
    connect(ui->cb_rainflow,&QCheckBox::stateChanged,[=]() mutable{rainflowFlag=!rainflowFlag;});
    connect(ui->cb_damage,&QCheckBox::stateChanged,[=]() mutable{damageComputeFlag=!damageComputeFlag;});
    connect(ui->cb_lowPass,&QCheckBox::stateChanged,[=]() mutable{lowPassFlag=!lowPassFlag;});
    connect(ui->cb_highPass,&QCheckBox::stateChanged,[=]() mutable{highPassFlag=!highPassFlag;});

    //单位同步与保存
    connect(ui->le_unit,&QLineEdit::textChanged,[=](QString text)mutable{ui->lb_unit->setText(unit=text);});
}

void SENSORCONFIG::on_pushButton_yseCreate_clicked()
{



}

/*-------------------------------取消创建-------------------------------*/
void SENSORCONFIG::on_pushButton_noExit_clicked()
{
    this->close();
    delete this;//取消创建，关闭窗口然后释放指针空间
}
