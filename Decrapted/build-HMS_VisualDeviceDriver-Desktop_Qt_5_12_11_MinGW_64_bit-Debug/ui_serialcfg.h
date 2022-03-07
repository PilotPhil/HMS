/********************************************************************************
** Form generated from reading UI file 'serialcfg.ui'
**
** Created by: Qt User Interface Compiler version 5.12.11
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SERIALCFG_H
#define UI_SERIALCFG_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SerialCfg
{
public:
    QGridLayout *gridLayout_2;
    QGroupBox *groupBox;
    QGridLayout *gridLayout;
    QLabel *LB_serialPort;
    QComboBox *CB_serialPort;
    QLabel *LB_baudRate;
    QComboBox *CB_baudRate;
    QLabel *LB_dataBit;
    QComboBox *CB_dataBit;
    QLabel *LB_checkBit;
    QComboBox *CB_checkBit;
    QLabel *LB_stopBit;
    QComboBox *CB_stopBit;
    QPushButton *PB_openSerial;
    QSpacerItem *horizontalSpacer;
    QSpacerItem *verticalSpacer;

    void setupUi(QWidget *SerialCfg)
    {
        if (SerialCfg->objectName().isEmpty())
            SerialCfg->setObjectName(QString::fromUtf8("SerialCfg"));
        SerialCfg->resize(474, 508);
        SerialCfg->setMinimumSize(QSize(0, 280));
        SerialCfg->setMaximumSize(QSize(16777215, 16777215));
        gridLayout_2 = new QGridLayout(SerialCfg);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        groupBox = new QGroupBox(SerialCfg);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        gridLayout = new QGridLayout(groupBox);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        LB_serialPort = new QLabel(groupBox);
        LB_serialPort->setObjectName(QString::fromUtf8("LB_serialPort"));
        LB_serialPort->setMaximumSize(QSize(80, 40));
        QFont font;
        font.setFamily(QString::fromUtf8("PibotoLt"));
        font.setPointSize(16);
        font.setBold(true);
        font.setItalic(true);
        font.setWeight(75);
        LB_serialPort->setFont(font);

        gridLayout->addWidget(LB_serialPort, 0, 0, 1, 1);

        CB_serialPort = new QComboBox(groupBox);
        CB_serialPort->setObjectName(QString::fromUtf8("CB_serialPort"));
        CB_serialPort->setMinimumSize(QSize(150, 40));
        QFont font1;
        font1.setFamily(QString::fromUtf8("PibotoLt"));
        font1.setPointSize(16);
        font1.setBold(false);
        font1.setItalic(false);
        font1.setWeight(50);
        CB_serialPort->setFont(font1);

        gridLayout->addWidget(CB_serialPort, 0, 1, 1, 1);

        LB_baudRate = new QLabel(groupBox);
        LB_baudRate->setObjectName(QString::fromUtf8("LB_baudRate"));
        LB_baudRate->setMaximumSize(QSize(80, 40));
        LB_baudRate->setFont(font);

        gridLayout->addWidget(LB_baudRate, 1, 0, 1, 1);

        CB_baudRate = new QComboBox(groupBox);
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->addItem(QString());
        CB_baudRate->setObjectName(QString::fromUtf8("CB_baudRate"));
        CB_baudRate->setMinimumSize(QSize(150, 40));
        CB_baudRate->setFont(font1);

        gridLayout->addWidget(CB_baudRate, 1, 1, 1, 1);

        LB_dataBit = new QLabel(groupBox);
        LB_dataBit->setObjectName(QString::fromUtf8("LB_dataBit"));
        LB_dataBit->setMaximumSize(QSize(80, 40));
        LB_dataBit->setFont(font);

        gridLayout->addWidget(LB_dataBit, 2, 0, 1, 1);

        CB_dataBit = new QComboBox(groupBox);
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->setObjectName(QString::fromUtf8("CB_dataBit"));
        CB_dataBit->setMinimumSize(QSize(150, 40));
        CB_dataBit->setFont(font1);

        gridLayout->addWidget(CB_dataBit, 2, 1, 1, 1);

        LB_checkBit = new QLabel(groupBox);
        LB_checkBit->setObjectName(QString::fromUtf8("LB_checkBit"));
        LB_checkBit->setMaximumSize(QSize(80, 40));
        LB_checkBit->setFont(font);

        gridLayout->addWidget(LB_checkBit, 3, 0, 1, 1);

        CB_checkBit = new QComboBox(groupBox);
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->setObjectName(QString::fromUtf8("CB_checkBit"));
        CB_checkBit->setMinimumSize(QSize(150, 40));
        CB_checkBit->setFont(font1);

        gridLayout->addWidget(CB_checkBit, 3, 1, 1, 1);

        LB_stopBit = new QLabel(groupBox);
        LB_stopBit->setObjectName(QString::fromUtf8("LB_stopBit"));
        LB_stopBit->setMaximumSize(QSize(80, 40));
        LB_stopBit->setFont(font);

        gridLayout->addWidget(LB_stopBit, 4, 0, 1, 1);

        CB_stopBit = new QComboBox(groupBox);
        CB_stopBit->addItem(QString());
        CB_stopBit->addItem(QString());
        CB_stopBit->addItem(QString());
        CB_stopBit->setObjectName(QString::fromUtf8("CB_stopBit"));
        CB_stopBit->setMinimumSize(QSize(150, 40));
        CB_stopBit->setFont(font1);
        CB_stopBit->setFrame(true);

        gridLayout->addWidget(CB_stopBit, 4, 1, 1, 1);

        PB_openSerial = new QPushButton(groupBox);
        PB_openSerial->setObjectName(QString::fromUtf8("PB_openSerial"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(PB_openSerial->sizePolicy().hasHeightForWidth());
        PB_openSerial->setSizePolicy(sizePolicy);
        PB_openSerial->setMinimumSize(QSize(150, 40));
        PB_openSerial->setMaximumSize(QSize(16777215, 40));
        PB_openSerial->setFont(font1);

        gridLayout->addWidget(PB_openSerial, 5, 1, 1, 1);


        gridLayout_2->addWidget(groupBox, 0, 0, 1, 1);

        horizontalSpacer = new QSpacerItem(204, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout_2->addItem(horizontalSpacer, 0, 1, 1, 1);

        verticalSpacer = new QSpacerItem(20, 175, QSizePolicy::Minimum, QSizePolicy::Expanding);

        gridLayout_2->addItem(verticalSpacer, 1, 0, 1, 1);


        retranslateUi(SerialCfg);

        QMetaObject::connectSlotsByName(SerialCfg);
    } // setupUi

    void retranslateUi(QWidget *SerialCfg)
    {
        SerialCfg->setWindowTitle(QApplication::translate("SerialCfg", "SMOS::\344\270\262\345\217\243\351\200\232\344\277\241\351\205\215\347\275\256", nullptr));
        groupBox->setTitle(QApplication::translate("SerialCfg", "Serial", nullptr));
        LB_serialPort->setText(QApplication::translate("SerialCfg", "Port", nullptr));
        LB_baudRate->setText(QApplication::translate("SerialCfg", "Baud", nullptr));
        CB_baudRate->setItemText(0, QApplication::translate("SerialCfg", "300", nullptr));
        CB_baudRate->setItemText(1, QApplication::translate("SerialCfg", "600", nullptr));
        CB_baudRate->setItemText(2, QApplication::translate("SerialCfg", "1200", nullptr));
        CB_baudRate->setItemText(3, QApplication::translate("SerialCfg", "2400", nullptr));
        CB_baudRate->setItemText(4, QApplication::translate("SerialCfg", "4800", nullptr));
        CB_baudRate->setItemText(5, QApplication::translate("SerialCfg", "9600", nullptr));
        CB_baudRate->setItemText(6, QApplication::translate("SerialCfg", "14400", nullptr));
        CB_baudRate->setItemText(7, QApplication::translate("SerialCfg", "19200", nullptr));
        CB_baudRate->setItemText(8, QApplication::translate("SerialCfg", "38400", nullptr));
        CB_baudRate->setItemText(9, QApplication::translate("SerialCfg", "56000", nullptr));
        CB_baudRate->setItemText(10, QApplication::translate("SerialCfg", "57600", nullptr));
        CB_baudRate->setItemText(11, QApplication::translate("SerialCfg", "115200", nullptr));
        CB_baudRate->setItemText(12, QApplication::translate("SerialCfg", "128000", nullptr));
        CB_baudRate->setItemText(13, QApplication::translate("SerialCfg", "256000", nullptr));
        CB_baudRate->setItemText(14, QApplication::translate("SerialCfg", "460800", nullptr));

        CB_baudRate->setCurrentText(QApplication::translate("SerialCfg", "300", nullptr));
        LB_dataBit->setText(QApplication::translate("SerialCfg", "DataBits", nullptr));
        CB_dataBit->setItemText(0, QApplication::translate("SerialCfg", "5", nullptr));
        CB_dataBit->setItemText(1, QApplication::translate("SerialCfg", "6", nullptr));
        CB_dataBit->setItemText(2, QApplication::translate("SerialCfg", "7", nullptr));
        CB_dataBit->setItemText(3, QApplication::translate("SerialCfg", "8", nullptr));

        CB_dataBit->setCurrentText(QApplication::translate("SerialCfg", "5", nullptr));
        LB_checkBit->setText(QApplication::translate("SerialCfg", "Parity", nullptr));
        CB_checkBit->setItemText(0, QApplication::translate("SerialCfg", "None", nullptr));
        CB_checkBit->setItemText(1, QApplication::translate("SerialCfg", "Even", nullptr));
        CB_checkBit->setItemText(2, QApplication::translate("SerialCfg", "Mark", nullptr));
        CB_checkBit->setItemText(3, QApplication::translate("SerialCfg", "Odd", nullptr));

        LB_stopBit->setText(QApplication::translate("SerialCfg", "StopBits", nullptr));
        CB_stopBit->setItemText(0, QApplication::translate("SerialCfg", "1", nullptr));
        CB_stopBit->setItemText(1, QApplication::translate("SerialCfg", "1.5", nullptr));
        CB_stopBit->setItemText(2, QApplication::translate("SerialCfg", "2", nullptr));

        PB_openSerial->setText(QApplication::translate("SerialCfg", "Open", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SerialCfg: public Ui_SerialCfg {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SERIALCFG_H
