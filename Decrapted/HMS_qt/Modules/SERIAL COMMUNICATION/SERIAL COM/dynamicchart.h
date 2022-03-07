#ifndef DYNAMICCHART_H
#define DYNAMICCHART_H

#include <QWidget>
#include <QString>
#include <QDebug>
#include <QtCharts>
#include <QPen>
#include <QTimer>
#include <QRandomGenerator>

using namespace QtCharts;

namespace Ui {
class DynamicChart;
}

class DynamicChart : public QWidget
{
    Q_OBJECT

public:
    explicit DynamicChart(QWidget *parent = nullptr);
    ~DynamicChart();

public slots:
    void ScrollDraw(qreal dp);//滚动绘制槽函数
    void sltClearChart();


private:
    Ui::DynamicChart *ui;

    QChart *chart;
    QLineSeries *series;
    QValueAxis *axisX_bottom;
    QValueAxis *axisY_right;
    QValueAxis *axisY_left;//左侧的y轴
    qreal scroll_x;
    qreal delta_x;

    qreal coordinate_x;

    qreal axisY_min;
    qreal axisY_max;

    qint32 num;
};

#endif // DYNAMICCHART_H
