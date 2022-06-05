#ifndef SENSORCONFIG_H
#define SENSORCONFIG_H

#include <QDialog>
#include <QDebug>

namespace Ui {
class SENSORCONFIG;
}

class SENSORCONFIG : public QDialog
{
    Q_OBJECT

public:
    explicit SENSORCONFIG(QWidget *parent = nullptr);
    ~SENSORCONFIG();

private slots:
    void on_pushButton_yseCreate_clicked();

    void on_pushButton_noExit_clicked();

private:
    Ui::SENSORCONFIG *ui;

    bool rawDataFlag;           //原始数据
    bool meanFlag;              //均值
    bool stdFlag;               //标准值
    bool zeroCrossFlag;         //平均跨零率
    bool peakVallyDetectFlag;   //峰谷检测
    bool rainflowFlag;          //雨流计数
    bool damageComputeFlag;     //累积损伤
    bool lowPassFlag;           //低通滤波
    bool highPassFlag;          //高通滤波

    QString unit;               //单位

    void allConnect();
};

#endif // SENSORCONFIG_H
