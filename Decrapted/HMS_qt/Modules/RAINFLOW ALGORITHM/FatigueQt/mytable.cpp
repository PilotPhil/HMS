#include "mytable.h"
#include "ui_mytable.h"

MYTABLE::MYTABLE(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::MYTABLE)
{
    ui->setupUi(this);

    model=new QStandardItemModel(this);
    selection=new QItemSelectionModel(model);

    //设置表头
    QStringList labels;
    labels<<"Count"<<"Range"<<"Mean"<<"Start"<<"End";
    model->setHorizontalHeaderLabels(labels);

    ui->tableView->verticalHeader()->hide();//隐藏垂直表头

    ui->tableView->setAlternatingRowColors(true);//设置相邻行颜色交替显示

    ui->tableView->setEditTriggers(QAbstractItemView::NoEditTriggers);//设置禁用表格编辑

    ui->tableView->setModel(model);

    //设置列数
    model->setColumnCount(5);


    //设置列宽度
    ui->tableView->horizontalHeader()->setSectionResizeMode(QHeaderView::Stretch);
    ui->tableView->horizontalHeader()->setSectionResizeMode(0,QHeaderView::Fixed);
    ui->tableView->setColumnWidth(0,90);
}

MYTABLE::~MYTABLE()
{
    delete ui;
}

void MYTABLE::UpdateTable(QVector<double> count, QVector<double> range, QVector<double> mean, QVector<double> start, QVector<double> end)
{

    model->setRowCount(count.count());

//    for(int i=0;i<5;i++)
//    {
//        model->removeColumn(i);
//    }


    for(int i=0;i<count.count();i++)
    {
        item=new QStandardItem(QString::number(count.at(i)));
        item->setTextAlignment(Qt::AlignHCenter);
        model->setItem(i,0,item);

        item=new QStandardItem(QString::number(range.at(i)));
        item->setTextAlignment(Qt::AlignHCenter);
        model->setItem(i,1,item);

        item=new QStandardItem(QString::number(mean.at(i)));
        item->setTextAlignment(Qt::AlignHCenter);
        model->setItem(i,2,item);

        item=new QStandardItem(QString::number(start.at(i)));
        item->setTextAlignment(Qt::AlignHCenter);
        model->setItem(i,3,item);

        item=new QStandardItem(QString::number(end.at(i)));
        item->setTextAlignment(Qt::AlignHCenter);
        model->setItem(i,4,item);
    }
}
