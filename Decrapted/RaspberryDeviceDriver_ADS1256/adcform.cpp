#include "adcform.h"
#include "ui_adcform.h"


#include "ADS1256/ADS1256.h"

AdcForm::AdcForm(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::AdcForm)
{
    ui->setupUi(this);

    //Init
    DEV_ModuleInit();

    if(ADS1256_init() == 1)
    {
       DEV_ModuleExit();
       exit(0);
    }

    readAdc=new TreadReadAdc();
    readAdc->start();

    this->toStress=ui->te_toStress->toPlainText().toDouble();

    connect(readAdc,&TreadReadAdc::SendAdcVal,this,&AdcForm::update2Form);
}

AdcForm::~AdcForm()
{
    delete ui;
    delete readAdc;
}

//update 2 form
void AdcForm::update2Form(double adcVal[])
{
    ui->te_0->setText(QString::number(adcVal[0]));
    ui->te_stress_0->setText(QString::number(adcVal[0]*toStress));

    ui->te_1->setText(QString::number(adcVal[1]));
    ui->te_stress_0->setText(QString::number(adcVal[1]*toStress));

    ui->te_2->setText(QString::number(adcVal[2]));
    ui->te_stress_0->setText(QString::number(adcVal[2]*toStress));

    ui->te_3->setText(QString::number(adcVal[3]));
    ui->te_stress_0->setText(QString::number(adcVal[3]*toStress));

    ui->te_4->setText(QString::number(adcVal[4]));
    ui->te_stress_0->setText(QString::number(adcVal[4]*toStress));

    ui->te_5->setText(QString::number(adcVal[5]));
    ui->te_stress_0->setText(QString::number(adcVal[5]*toStress));

    ui->te_6->setText(QString::number(adcVal[6]));
    ui->te_stress_0->setText(QString::number(adcVal[6]*toStress));

    ui->te_7->setText(QString::number(adcVal[7]));
    ui->te_stress_0->setText(QString::number(adcVal[7]*toStress));
}
//set adc cfg
void AdcForm::SetAdcCfg()
{
    readAdc->StopRead();

    this->toStress=ui->te_toStress->toPlainText().toDouble();

    //set mode
    int mode=ui->cmb_mode->currentIndex();
    if(mode==0 || mode==1)
        ADS1256_SetMode(uint8_t(mode));

    //set gain & rate
    int _gain=ui->cmb_gain->currentIndex();
    int _rate=ui->cmb_drates->currentIndex();

    ADS1256_GAIN gain=ADS1256_GAIN_1;
    switch (_gain)
    {
        case 0:gain=ADS1256_GAIN_1;break;
        case 1:gain=ADS1256_GAIN_2;break;
        case 2:gain=ADS1256_GAIN_4;break;
        case 3:gain=ADS1256_GAIN_8;break;
        case 4:gain=ADS1256_GAIN_16;break;
        case 5:gain=ADS1256_GAIN_32;break;
        case 6:gain=ADS1256_GAIN_64;break;

        default:break;
    }

    ADS1256_DRATE DRate=ADS1256_5SPS;
    switch (_rate)
    {
        case 0:DRate=ADS1256_30000SPS;break;
        case 1:DRate=ADS1256_15000SPS;break;
        case 2:DRate=ADS1256_7500SPS;break;
        case 3:DRate=ADS1256_3750SPS;break;
        case 4:DRate=ADS1256_2000SPS;break;
        case 5:DRate=ADS1256_1000SPS;break;
        case 6:DRate=ADS1256_500SPS;break;
        case 7:DRate=ADS1256_100SPS;break;
        case 8:DRate=ADS1256_60SPS;break;
        case 9:DRate=ADS1256_50SPS;break;
        case 10:DRate=ADS1256_30SPS;break;
        case 11:DRate=ADS1256_25SPS;break;
        case 12:DRate=ADS1256_15SPS;break;
        case 13:DRate=ADS1256_10SPS;break;
        case 14:DRate=ADS1256_5SPS;break;
        case 15:DRate=ADS1256_2d5SPS;break;
        default:break;
    }

    ADS1256_ConfigADC(gain,DRate);
}
//start
void AdcForm::StartAdc()
{
    if(ui->pb_start->isChecked()==true)
    {
        readAdc->StartRead();
        ui->pb_start->setText("Stop");
    }
    else
    {
        readAdc->StopRead();
        ui->pb_start->setText("Start");
    }
}

void AdcForm::on_pb_start_clicked()
{
    this->StartAdc();
}

void AdcForm::on_pb_setCfg_clicked()
{
    this->SetAdcCfg();
}
