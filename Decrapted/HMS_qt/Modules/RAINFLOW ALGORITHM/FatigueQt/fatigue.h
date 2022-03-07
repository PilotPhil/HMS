#ifndef FATIGUE_H
#define FATIGUE_H

#include <QWidget>
#include <QVector>
#include <QPointF>
#include <QDebug>
#include <QLineSeries>
#include <QFile>
#include <QFileDialog>

#include "SN_FATIGUE.h"
#include "mychart.h"
#include "mytable.h"
#include "docsv.h"

typedef QVector<double> DF;//在此类中常用的数据型别 data format

namespace Ui {
class FATIGUE;
}

class FATIGUE : public QWidget
{
    Q_OBJECT

public:
    explicit FATIGUE(QWidget *parent = nullptr);
    ~FATIGUE();

    void allConnect();                           //所有信号与槽链接
    void loadQSS();                              //加载样式表
    void process(DF peakVally);     //总处理函数



private slots:
    void on_CB_rawData_clicked(bool checked);
    void on_CB_peakVally_clicked(bool checked);
    void on_PB_inputData_clicked();

    void receiveRData(RData *rd);

    void receiveCsvData(DF peakVally);     //接收表格数据槽函数

    void on_comboBox_currentIndexChanged(int index);

    void on_doubleSpinBox_valueChanged(double arg1);

    void on_PB_reCompute_clicked();

signals:
    void sendAll2Table(DF count,DF range,DF mean,DF start,DF end);//发送所有数据给表格
    void sendCsvFileName(QString fileName);             //发送选择的文件名
    void sendKValues(double K);                         //发送sn曲线中K值
    void sendUltraStress(double U);                     //发送屈服应力

private:
    Ui::FATIGUE *ui;

    RData * rd;             //
    RAINFLOW * rf;          //雨流计数对象
    DAMAGE *DM;

    MYCHART * myChart;              //折线表对象
    MYTABLE * myTable;              //表格对象
    DOCSV * readCsv;                //读取csv对象

    DF * data;         //读取的数据

    DF * peakVally;    //峰谷

    QLineSeries * rawDataSeries;    //原始数据折线序列
    QLineSeries * peakVallySeries;  //峰谷点数据折线序列
};

#endif // FATIGUE_H
