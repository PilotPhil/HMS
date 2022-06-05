#include "sqlTable.h"
#include "ui_sqlTable.h"

#include "database.h"

SQL_TABLE::SQL_TABLE(QWidget *parent, QString tableName) :
    QWidget(parent),
    ui(new Ui::SQL_TABLE)
{
    ui->setupUi(this);

    model=new QSqlTableModel(this);

    model->setTable(tableName);//模型绑定数据库中的表格

    ui->tableView->setModel(model);//空间设置模型

    ui->tableView->horizontalHeader()->setSectionResizeMode(QHeaderView::Stretch);//设置列宽度自动延展

//    ui->tableView->verticalHeader()->hide();

    model->select();//刷新数据

    model->setEditStrategy(QSqlTableModel::OnManualSubmit);//设置手动提交

    ui->tableView->setAlternatingRowColors(true);//开启交替颜色

}

SQL_TABLE::~SQL_TABLE()
{
    delete ui;
}

/*-------------------------------设置横向表头-------------------------------*/
void SQL_TABLE::setHorizontalHeaders(const QStringList &headList)
{
    for(int i=0;i<headList.count();i++)
    {
        model->setHeaderData(i,Qt::Horizontal,headList.at(i));
    }
}

/*-------------------------------刷新表格数据-------------------------------*/
void SQL_TABLE::refreshTable()
{
    model->select();//刷新表格内数据
}

void SQL_TABLE::insert2Table()
{
    QSqlRecord record=model->record();

    model->insertRecord(model->rowCount(),record);
}

void SQL_TABLE::submit()
{
    model->submitAll();
}

void SQL_TABLE::deleteSelected()
{
    if(QMessageBox::warning(this,"警告","确认删除?",QMessageBox::Yes,QMessageBox::Cancel)==QMessageBox::Cancel)
    {
        return;
    }

    QItemSelectionModel * sModel=ui->tableView->selectionModel();

    QModelIndexList list=sModel->selectedRows();

    for(int i=0;i<list.count();i++)
    {
        model->removeRow(list.at(i).row());
    }
    model->submitAll();
}

void SQL_TABLE::revert()
{
    model->revertAll();
    model->submitAll();
}

