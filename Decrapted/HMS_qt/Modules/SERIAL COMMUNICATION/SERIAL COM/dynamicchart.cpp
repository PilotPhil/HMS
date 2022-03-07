#include "dynamicchart.h"
#include "ui_dynamicchart.h"

DynamicChart::DynamicChart(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::DynamicChart)
{
    ui->setupUi(this);

    chart=new QChart();
    series=new QLineSeries(this);
    series->setUseOpenGL(true);

    QPen pen(Qt::blue);
    pen.setWidth(1);
    series->setPen(pen);

    ui->graphicsView->setChart(chart);

    chart->legend()->hide();

    //设置坐标轴
    axisX_bottom=new QValueAxis(this);
    axisY_right=new QValueAxis(this);
    axisY_left=new QValueAxis(this);

    chart->addSeries(series);
    chart->addAxis(axisX_bottom,Qt::AlignBottom);//x轴添加在底部
    chart->addAxis(axisY_right,Qt::AlignRight);//y轴添加在右边
    chart->addAxis(axisY_left,Qt::AlignLeft);//左侧的y轴

    series->attachAxis(axisX_bottom);
    series->attachAxis(axisY_right);
    series->attachAxis(axisY_left);

    axisX_bottom->setTickCount(11);//x轴细分（包含端点）
    axisX_bottom->setRange(0,1000);
    axisX_bottom->setLabelFormat("%d");//坐标轴刻度取整

    axisY_left->setTickCount(6);//Y轴细分（包含端点）
    axisY_left->setRange(0,0);
    axisY_left->setLabelFormat("%d");//坐标轴刻度取整

    axisY_right->setTickCount(6);//Y轴细分（包含端点）
    axisY_right->setRange(0,0);
    axisY_right->setLabelFormat("%d");//坐标轴刻度取整

    axisY_min=0;
    axisY_max=0;

    //coordinate_x=axisX_bottom->max();//x轴坐标起点设在图最右边
    coordinate_x=1;
    num=0;//数据点数量

    //数据序列清空
    series->clear();
}

DynamicChart::~DynamicChart()
{
    delete ui;
}

//绘制函数
void DynamicChart::ScrollDraw(qreal dp)
{
    if(chart->isVisible()==true)//图表可见再绘制
    {
        qDebug()<<"Draw";
        scroll_x = chart->plotArea().width() / axisX_bottom->max();//x轴每次滚动量
        delta_x = (axisX_bottom->max() - axisX_bottom->min()) / axisX_bottom->max();//x轴坐标增量
        coordinate_x += delta_x;//加上增量
        series->append(coordinate_x, dp);//序列增加数据点

        num++;
        if(num>axisX_bottom->max())
        {
            chart->scroll(scroll_x, 0);//滚动x轴
        }

        if(dp>axisY_max)//数据大于y轴最大值
        {
            axisY_max=dp;
        }
        if(dp<axisY_min)//数据小于y轴最大值
        {
            axisY_min=dp;
        }
        axisY_right->setRange(axisY_min,axisY_max);//更新坐标轴Y
        axisY_left->setRange(axisY_min,axisY_max);//更新坐标轴Y
    }
    else
    {
        qDebug()<<"图表被隐藏，图表将不更新";
    }

}

//清空图标
void DynamicChart::sltClearChart()
{
    series->clear();
    //coordinate_x=axisX_bottom->max();//x轴坐标起点设在图最右边
    axisY_max=0;
    axisY_min=0;
    axisY_right->setRange(axisY_min,axisY_max);//更新坐标轴Y
    axisY_left->setRange(axisY_min,axisY_max);//更新坐标轴Y
    axisX_bottom->setRange(0,1000);
    num=0;
    coordinate_x=1;
}

