/********************************************************************************
** Form generated from reading UI file 'visualdevicedriver.ui'
**
** Created by: Qt User Interface Compiler version 5.12.11
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_VISUALDEVICEDRIVER_H
#define UI_VISUALDEVICEDRIVER_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QTabWidget>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_VisualDeviceDriver
{
public:
    QGridLayout *gridLayout;
    QTabWidget *tabWidget;
    QWidget *tab;
    QGridLayout *gridLayout_2;
    QWidget *wgt_adsSettings;
    QWidget *tab_2;
    QGridLayout *gridLayout_3;
    QWidget *wgt_serial;
    QWidget *tab_3;

    void setupUi(QWidget *VisualDeviceDriver)
    {
        if (VisualDeviceDriver->objectName().isEmpty())
            VisualDeviceDriver->setObjectName(QString::fromUtf8("VisualDeviceDriver"));
        VisualDeviceDriver->resize(779, 600);
        gridLayout = new QGridLayout(VisualDeviceDriver);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        tabWidget = new QTabWidget(VisualDeviceDriver);
        tabWidget->setObjectName(QString::fromUtf8("tabWidget"));
        tab = new QWidget();
        tab->setObjectName(QString::fromUtf8("tab"));
        gridLayout_2 = new QGridLayout(tab);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        wgt_adsSettings = new QWidget(tab);
        wgt_adsSettings->setObjectName(QString::fromUtf8("wgt_adsSettings"));

        gridLayout_2->addWidget(wgt_adsSettings, 0, 0, 1, 1);

        tabWidget->addTab(tab, QString());
        tab_2 = new QWidget();
        tab_2->setObjectName(QString::fromUtf8("tab_2"));
        gridLayout_3 = new QGridLayout(tab_2);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        wgt_serial = new QWidget(tab_2);
        wgt_serial->setObjectName(QString::fromUtf8("wgt_serial"));

        gridLayout_3->addWidget(wgt_serial, 0, 0, 1, 1);

        tabWidget->addTab(tab_2, QString());
        tab_3 = new QWidget();
        tab_3->setObjectName(QString::fromUtf8("tab_3"));
        tabWidget->addTab(tab_3, QString());

        gridLayout->addWidget(tabWidget, 0, 0, 1, 1);


        retranslateUi(VisualDeviceDriver);

        tabWidget->setCurrentIndex(0);


        QMetaObject::connectSlotsByName(VisualDeviceDriver);
    } // setupUi

    void retranslateUi(QWidget *VisualDeviceDriver)
    {
        VisualDeviceDriver->setWindowTitle(QApplication::translate("VisualDeviceDriver", "VisualDeviceDriver", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab), QApplication::translate("VisualDeviceDriver", "ADC", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_2), QApplication::translate("VisualDeviceDriver", "COM", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_3), QApplication::translate("VisualDeviceDriver", "CNV", nullptr));
    } // retranslateUi

};

namespace Ui {
    class VisualDeviceDriver: public Ui_VisualDeviceDriver {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_VISUALDEVICEDRIVER_H
