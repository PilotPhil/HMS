#include "treadreadadc.h"

#include "ADS1256/ADS1256.h"

Q_DECLARE_METATYPE(double *)

TreadReadAdc::TreadReadAdc()
{
    _isReading=false;
    qRegisterMetaType<double *>("double[8]");
}

//Start
void TreadReadAdc::StartRead()
{
    _isReading=true;
    qDebug()<<"------Start Read ADC------";
}

//Stop
void TreadReadAdc::StopRead()
{
    _isReading=false;
    qDebug()<<"------Stop Read ADC------";
}

//Run Thread
void TreadReadAdc::run()
{
    //read in while
    while (1)
    {
        if(_isReading==true)
        {
            for(int i=0;i<=7;i++)
            {
                AdcVal[i]=ADS1256_GetChannalValue(i)*5.0/0x7fffff;
            }

            //emit
            emit SendAdcVal(AdcVal);
        }

    }
}
