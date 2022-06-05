#ifndef DATABASE_H
#define DATABASE_H

#include <QObject>
#include <QDebug>
#include <QSqlQuery>
#include <QSqlError>
#include <QDir>
#include <QFile>
#include <QMessageBox>
#include <QString>

const QString DB_NAME="HMS";

class DATABASE : public QObject
{
    Q_OBJECT
protected:
    explicit DATABASE(QObject *parent = nullptr);

public:
    ~DATABASE();
    static DATABASE * dbInstance(QObject *parent);

    void dbInit();

    void insert2SensorCfg(int id,QString type,QString name,QString location);

    void orderByType(const QString &tableName,const QString &order);

    void selectAllFrom(const QString &tableName);

private:
    static DATABASE * _dbInstance;
    QSqlDatabase db;
};

#endif // SENSOR_CONFIG_DB_H
