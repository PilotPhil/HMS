#ifndef HMS_H
#define HMS_H

#include <QWidget>
#include <qdebug.h>
#include <QtSql/QSqlQuery>
#include <QGridLayout>

#include "sensorconfig.h"

#include "database.h"

#include "sqlTable.h"

#include "COM/SERIAL/serialcfg.h"
#include "COM/UDP/udpui.h"

QT_BEGIN_NAMESPACE
namespace Ui { class HMS; }
QT_END_NAMESPACE

class HMS : public QWidget
{
    Q_OBJECT

public:
    HMS(QWidget *parent = nullptr);
    ~HMS();

private slots:
    void on_pushButton_refresh_clicked(){sensorTable->refreshTable();}

    void on_pushButton_add_clicked(){sensorTable->insert2Table();}

    void on_pushButton_delete_clicked(){sensorTable->deleteSelected();}

    void on_pushButton_apply_clicked(){sensorTable->submit();}

    void on_pushButton_cancel_clicked(){sensorTable->revert();}


    void on_pushButton_edit_clicked();


    void on_pushButton_useUdp_clicked();

    void on_pushButton_useSerial_clicked();

private:
    Ui::HMS *ui;

    DATABASE *db;

    SQL_TABLE *sensorTable;

    UDPUI *udpui;

    SerialCfg *serialCom;
};
#endif // HMS_H
