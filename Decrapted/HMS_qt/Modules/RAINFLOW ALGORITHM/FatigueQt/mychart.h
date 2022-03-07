#ifndef MYCHART_H
#define MYCHART_H

#include <QWidget>
#include <QString>
#include <QDebug>
#include <QtCharts>
#include <QPen>
#include <QVector>
#include <QLineSeries>

namespace Ui {
class MYCHART;
}

class MYCHART : public QWidget
{
    Q_OBJECT

public:
    explicit MYCHART(QWidget *parent = nullptr);
    ~MYCHART();

    QLineSeries *myMakeSeries(QVector<double> y);//不提供x轴数据，就按照y轴数据点长度生成x轴
    QLineSeries *myMakeSeries(QVector<double> x,QVector<double> y);//提供（x,y）生成折线数据序列

    void myAddSeries(QLineSeries *series);
    void myRemoveSeries(QLineSeries *series);
    void myAdjustAxis(QVector<double> y);

private:
    Ui::MYCHART *ui;

    QChart *chart;
    QSplineSeries *series;
    QStringList titles;
    QValueAxis *axisX;
    QValueAxis *axisY;
    qreal step;
    qreal x;
    qreal y;


};

#endif // MYCHART_H
