#include "sm.h"

SM::SM(QObject *parent) : QObject(parent)
{
    res=new std::vector<double>;
}

SM::~SM()
{
    delete res;
}

std::vector<double> SM::SM_Process(const std::vector<double> &data)
{
    res->clear();

    res->push_back(this->Max(data));//最大值0
    res->push_back(this->Min(data));//最小值1
    res->push_back(this->Mean(data));//均值2
    res->push_back(this->Std(data));//标准差3
    res->push_back(this->Skw(data));//偏度4
    res->push_back(this->Kut(data));//峭度5
    res->push_back(this->Zcr(data));//平均跨零率6

    qDebug()<<*res;

    return *res;
}

//最大值
double SM::Max(const std::vector<double> &data)//0
{
    return *std::max_element(data.begin(),data.end());
}

//最小值
double SM::Min(const std::vector<double> &data)//1
{
    return *std::min_element(data.begin(),data.end());
}

//均值
double SM::Mean(const std::vector<double> &data)//2
{
    return std::accumulate(data.begin(),data.end(),0)/data.size();
}

//标准差
double SM::Std(const std::vector<double> &data)//3
{
    double temp=0;
    foreach(double d,data)
    {
        temp+=pow(d-res->at(2),2);
    }
    temp/=data.size()-1;
    temp=pow(temp,0.5);
    return temp;
}

//偏度
double SM::Skw(const std::vector<double> &data)//4
{
    double temp1=0;
    double temp2=0;

    foreach(double d,data)
    {
        temp1+=pow(d-res->at(2),3);
        temp2+=pow(d-res->at(2),2);
    }

    temp1/=data.size();
    temp2/=data.size();
    temp2=pow(temp2,1.5);

    return temp1/temp2;
}

//峭度
double SM::Kut(const std::vector<double> &data)//5
{
    double temp1=0;
    double temp2=0;

    foreach(double d,data)
    {
        temp1+=pow(d-res->at(2),4);
        temp2+=pow(d-res->at(2),2);
    }

    temp1/=data.size();
    temp2/=data.size();
    temp2=pow(temp2,2);

    return temp1/temp2;
}

//平均跨零率
double SM::Zcr(const std::vector<double> &data)//6
{
    double num=0;

    int i=0;
    while (i<int(data.size())-1)
    {
        if(data.at(i)*data.at(i+1)<0)
        {
            num++;
            i++;
        }
        else if (data.at(i)*data.at(i+1)==0)
        {
            num++;
            i+=2;
        }
        else
        {
            i++;
        }
    }

    qDebug()<<num;

    return num/data.size();
}
