#ifndef DOCSV_H
#define DOCSV_H

#include <QObject>
#include <QFile>
#include <QFileDialog>
#include <QDebug>
#include <QTextStream>

class DOCSV : public QObject
{
    Q_OBJECT
public:
    explicit DOCSV(QObject *parent = nullptr);

signals:
    void sendCsvData(QVector<double> data);

public slots:
    void receiveFileNameRead(QString fileName);


private:
    QVector<double> * data;

};

#endif // DOCSV_H
