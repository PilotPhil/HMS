#include "mychart.h"
#include "ui_mychart.h"

MYCHART::MYCHART(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::MYCHART)
{
    ui->setupUi(this);

    chart=new QChart();
    ui->chartView->setChart(chart);
    chart->legend()->hide();

    axisX=new QValueAxis(this);
    axisY=new QValueAxis(this);

    chart->addAxis(axisX,Qt::AlignBottom);
    chart->addAxis(axisY,Qt::AlignLeft);

    axisX->setRange(0,20);
    axisY->setRange(1,10);

    axisX->setTickCount(21);
    axisY->setTickCount(10);

    axisX->setLabelFormat("%d");
    axisY->setLabelFormat("%d");
}

MYCHART::~MYCHART()
{
    delete ui;
}

QLineSeries *MYCHART::myMakeSeries(QVector<double> y)
{
    QLineSeries *series=new QLineSeries;
    for(int i=0;i<y.size();i++)
    {
        series->append(i,y.at(i));
    }

    return series;
}

QLineSeries *MYCHART::myMakeSeries(QVector<double> x, QVector<double> y)
{
    QLineSeries *series=new QLineSeries;
    for(int i=0;i<x.size();i++)
    {
        series->append(x.at(i),y.at(i));
    }

    return series;
}

void MYCHART::myAddSeries(QLineSeries *series)
{
    chart->addSeries(series);

    series->attachAxis(axisX);
    series->attachAxis(axisY);
}

void MYCHART::myRemoveSeries(QLineSeries *series)
{
    series->detachAxis(axisX);
    series->detachAxis(axisY);

    chart->removeSeries(series);
}

void MYCHART::myAdjustAxis(QVector<double> y)
{
    //更改x轴范围
    int yLength=y.size();
    int mod=yLength/10;
    mod=(mod+1)*10;
    axisX->setRange(0,mod);
    axisX->setTickCount(11);

    //更改y轴范围
    auto yMin=std::min_element(std::begin(y),std::end(y));
    auto yMax=std::max_element(std::begin(y),std::end(y));

    axisY->setRange(floor(*yMin),ceil(*yMax));//自动判断类型，是指针，取值

//    axisY->setTickCount(ceil(*yMax)-floor(*yMin)+1);
    axisY->setTickCount(11);
}


