#include "smtest.h"
#include "ui_smtest.h"

SMTEST::SMTEST(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::SMTEST)
{
    ui->setupUi(this);

    sm=new SM(this);

    std::vector<double> data={1,2,-3,5,-4,3,0,3,0,-2,8};
    sm->SM_Process(data);

}

SMTEST::~SMTEST()
{
    delete ui;
}

