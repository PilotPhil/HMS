#ifndef MYTABLE_H
#define MYTABLE_H

#include <QWidget>
#include <QStandardItemModel>
#include <QItemSelectionModel>
#include <QFont>

namespace Ui {
class MYTABLE;
}

class MYTABLE : public QWidget
{
    Q_OBJECT

public:
    explicit MYTABLE(QWidget *parent = nullptr);
    ~MYTABLE();

    void UpdateTable(QVector<double> count,
                     QVector<double> range,QVector<double> mean,
                     QVector<double> start,QVector<double> end);

private:
    Ui::MYTABLE *ui;

    QStandardItemModel *model;
    QItemSelectionModel *selection;
    QStringList horizontalHeader;
    QStandardItem *item;
};

#endif // MYTABLE_H
