#ifndef ADCFORM_H
#define ADCFORM_H

#include <QWidget>
#include <QTextEdit>

#include "treadreadadc.h"

namespace Ui {
class AdcForm;
}

class AdcForm : public QWidget
{
    Q_OBJECT

public:
    explicit AdcForm(QWidget *parent = nullptr);
    ~AdcForm();

    void update2Form(double adcVal[8]);

    void StartAdc();
    void SetAdcCfg();

private slots:

    void on_pb_start_clicked();

    void on_pb_setCfg_clicked();

private:
    Ui::AdcForm *ui;

    double toStress;

    TreadReadAdc *readAdc;

};

#endif // ADCFORM_H
