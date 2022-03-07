#ifndef SENSOR_TABLE_H
#define SENSOR_TABLE_H

#include <QWidget>
#include <QSqlTableModel>
#include <QItemSelectionModel>
#include <QFont>
#include <QStringList>
#include <QSqlRecord>
#include <QItemSelectionModel>
#include <QMessageBox>

#include "database.h"

namespace Ui {
class SQL_TABLE;
}

class SQL_TABLE : public QWidget
{
    Q_OBJECT

public:
    explicit SQL_TABLE(QWidget *parent = nullptr,QString tableName="default");
    ~SQL_TABLE();

    void setHorizontalHeaders(const QStringList &headList);

    void refreshTable();

    void insert2Table();

    void submit();

    void deleteSelected();

    void revert();

private:
    Ui::SQL_TABLE *ui;

    QSqlTableModel *model;
    QItemSelectionModel *selection;
};

#endif // SENSOR_TABLE_H
