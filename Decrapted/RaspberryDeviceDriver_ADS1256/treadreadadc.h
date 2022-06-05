#ifndef TREADREADADC_H
#define TREADREADADC_H

#include <QObject>
#include <QThread>
#include <QDebug>
#include <QMetaType>

class TreadReadAdc : public QThread
{
    Q_OBJECT

public:
    TreadReadAdc();

    void StartRead();
    void StopRead();

protected:
    void run();

private:
    bool _isReading;

    double AdcVal[8]={0,0,0,0,0,0,0,0};

signals:
    void SendAdcVal(double AdcVal[8]);
};

#endif // TREADREADADC_H
