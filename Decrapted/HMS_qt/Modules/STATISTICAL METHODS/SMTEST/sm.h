#ifndef SM_H
#define SM_H

#include <QObject>
#include <vector>
#include <algorithm>
#include <numeric>
#include <math.h>
#include <QDebug>

class SM : public QObject
{
    Q_OBJECT
public:
    explicit SM(QObject *parent = nullptr);
    ~SM();

    std::vector<double> SM_Process(const std::vector<double> & data);

protected:
    double Max(const std::vector<double> & data);//最大值
    double Min(const std::vector<double> & data);//最小值
    double Mean(const std::vector<double> & data);//均值
    double Std(const std::vector<double> & data);//标准差
    double Skw(const std::vector<double> & data);//Skewness 偏度
    double Kut(const std::vector<double> & data);//Kurtosis 峭度
    double Zcr(const std::vector<double> & data);//ZCR平均跨零率

private:
    std::vector<double> * res;

signals:

};

#endif // SM_H
