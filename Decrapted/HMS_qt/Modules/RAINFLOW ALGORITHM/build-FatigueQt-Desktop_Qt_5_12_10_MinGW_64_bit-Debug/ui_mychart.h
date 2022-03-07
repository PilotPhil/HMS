/********************************************************************************
** Form generated from reading UI file 'mychart.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MYCHART_H
#define UI_MYCHART_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QWidget>
#include <qchartview.h>

QT_BEGIN_NAMESPACE

class Ui_MYCHART
{
public:
    QGridLayout *gridLayout;
    QChartView *chartView;

    void setupUi(QWidget *MYCHART)
    {
        if (MYCHART->objectName().isEmpty())
            MYCHART->setObjectName(QString::fromUtf8("MYCHART"));
        MYCHART->resize(400, 300);
        gridLayout = new QGridLayout(MYCHART);
        gridLayout->setSpacing(0);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        gridLayout->setContentsMargins(0, 0, 0, 0);
        chartView = new QChartView(MYCHART);
        chartView->setObjectName(QString::fromUtf8("chartView"));

        gridLayout->addWidget(chartView, 0, 0, 1, 1);


        retranslateUi(MYCHART);

        QMetaObject::connectSlotsByName(MYCHART);
    } // setupUi

    void retranslateUi(QWidget *MYCHART)
    {
        MYCHART->setWindowTitle(QApplication::translate("MYCHART", "Form", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MYCHART: public Ui_MYCHART {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MYCHART_H
