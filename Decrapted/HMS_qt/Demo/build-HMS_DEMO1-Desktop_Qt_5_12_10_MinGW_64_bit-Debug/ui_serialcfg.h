/********************************************************************************
** Form generated from reading UI file 'serialcfg.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SERIALCFG_H
#define UI_SERIALCFG_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPlainTextEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SerialCfg
{
public:
    QGridLayout *gridLayout_5;
    QGroupBox *groupBox;
    QGridLayout *gridLayout_2;
    QGridLayout *gridLayout;
    QLabel *LB_checkBit;
    QComboBox *CB_serialPort;
    QComboBox *CB_checkBit;
    QLabel *LB_serialPort;
    QComboBox *CB_baudRate;
    QComboBox *CB_stopBit;
    QLabel *LB_stopBit;
    QLabel *LB_baudRate;
    QLabel *LB_dataBit;
    QComboBox *CB_dataBit;
    QPushButton *PB_openSerial;
    QLabel *label_serialState;
    QGroupBox *groupBox_2;
    QGridLayout *gridLayout_3;
    QPlainTextEdit *PT_sendData;
    QPushButton *PB_sendSerialData;
    QGroupBox *groupBox_3;
    QGridLayout *gridLayout_4;
    QHBoxLayout *horizontalLayout;
    QVBoxLayout *verticalLayout_2;
    QCheckBox *checkBox_receiveOrNot;
    QCheckBox *checkBox_dispReceive;
    QPushButton *pushButton_clearDisp;
    QTextEdit *textEdit_showMsg;

    void setupUi(QWidget *SerialCfg)
    {
        if (SerialCfg->objectName().isEmpty())
            SerialCfg->setObjectName(QString::fromUtf8("SerialCfg"));
        SerialCfg->resize(352, 626);
        SerialCfg->setMinimumSize(QSize(0, 280));
        SerialCfg->setMaximumSize(QSize(16777215, 16777215));
        gridLayout_5 = new QGridLayout(SerialCfg);
        gridLayout_5->setObjectName(QString::fromUtf8("gridLayout_5"));
        groupBox = new QGroupBox(SerialCfg);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        gridLayout_2 = new QGridLayout(groupBox);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        gridLayout = new QGridLayout();
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        LB_checkBit = new QLabel(groupBox);
        LB_checkBit->setObjectName(QString::fromUtf8("LB_checkBit"));
        LB_checkBit->setMaximumSize(QSize(80, 40));

        gridLayout->addWidget(LB_checkBit, 3, 0, 1, 1);

        CB_serialPort = new QComboBox(groupBox);
        CB_serialPort->setObjectName(QString::fromUtf8("CB_serialPort"));
        CB_serialPort->setMinimumSize(QSize(0, 0));
        CB_serialPort->setMaximumSize(QSize(16777215, 16777215));

        gridLayout->addWidget(CB_serialPort, 0, 2, 1, 1);

        CB_checkBit = new QComboBox(groupBox);
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->addItem(QString());
        CB_checkBit->setObjectName(QString::fromUtf8("CB_checkBit"));
        CB_checkBit->setMinimumSize(QSize(0, 0));
        CB_checkBit->setMaximumSize(QSize(16777215, 16777215));

        gridLayout->addWidget(CB_checkBit, 3, 2, 1, 1);

        LB_serialPort = new QLabel(groupBox);
        LB_serialPort->setObjectName(QString::fromUtf8("LB_serialPort"));
        LB_serialPort->setMaximumSize(QSize(80, 40));

        gridLayout->addWidget(LB_serialPort, 0, 0, 1, 1);

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
        CB_baudRate->setMinimumSize(QSize(0, 0));
        CB_baudRate->setMaximumSize(QSize(16777215, 16777215));

        gridLayout->addWidget(CB_baudRate, 1, 2, 1, 1);

        CB_stopBit = new QComboBox(groupBox);
        CB_stopBit->addItem(QString());
        CB_stopBit->addItem(QString());
        CB_stopBit->addItem(QString());
        CB_stopBit->setObjectName(QString::fromUtf8("CB_stopBit"));
        CB_stopBit->setMinimumSize(QSize(0, 0));
        CB_stopBit->setMaximumSize(QSize(16777215, 16777215));
        CB_stopBit->setFrame(true);

        gridLayout->addWidget(CB_stopBit, 4, 2, 1, 1);

        LB_stopBit = new QLabel(groupBox);
        LB_stopBit->setObjectName(QString::fromUtf8("LB_stopBit"));
        LB_stopBit->setMaximumSize(QSize(80, 40));

        gridLayout->addWidget(LB_stopBit, 4, 0, 1, 1);

        LB_baudRate = new QLabel(groupBox);
        LB_baudRate->setObjectName(QString::fromUtf8("LB_baudRate"));
        LB_baudRate->setMaximumSize(QSize(80, 40));

        gridLayout->addWidget(LB_baudRate, 1, 0, 1, 1);

        LB_dataBit = new QLabel(groupBox);
        LB_dataBit->setObjectName(QString::fromUtf8("LB_dataBit"));
        LB_dataBit->setMaximumSize(QSize(80, 40));

        gridLayout->addWidget(LB_dataBit, 2, 0, 1, 1);

        CB_dataBit = new QComboBox(groupBox);
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->addItem(QString());
        CB_dataBit->setObjectName(QString::fromUtf8("CB_dataBit"));
        CB_dataBit->setMinimumSize(QSize(0, 0));
        CB_dataBit->setMaximumSize(QSize(16777215, 16777215));

        gridLayout->addWidget(CB_dataBit, 2, 2, 1, 1);

        PB_openSerial = new QPushButton(groupBox);
        PB_openSerial->setObjectName(QString::fromUtf8("PB_openSerial"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(PB_openSerial->sizePolicy().hasHeightForWidth());
        PB_openSerial->setSizePolicy(sizePolicy);
        PB_openSerial->setMinimumSize(QSize(0, 0));
        PB_openSerial->setMaximumSize(QSize(16777215, 16777215));
        PB_openSerial->setCheckable(true);

        gridLayout->addWidget(PB_openSerial, 5, 2, 1, 1);


        gridLayout_2->addLayout(gridLayout, 0, 0, 1, 1);

        label_serialState = new QLabel(groupBox);
        label_serialState->setObjectName(QString::fromUtf8("label_serialState"));

        gridLayout_2->addWidget(label_serialState, 1, 0, 1, 1);


        gridLayout_5->addWidget(groupBox, 0, 0, 1, 1);

        groupBox_2 = new QGroupBox(SerialCfg);
        groupBox_2->setObjectName(QString::fromUtf8("groupBox_2"));
        gridLayout_3 = new QGridLayout(groupBox_2);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        PT_sendData = new QPlainTextEdit(groupBox_2);
        PT_sendData->setObjectName(QString::fromUtf8("PT_sendData"));
        PT_sendData->setMaximumSize(QSize(16777215, 300));

        gridLayout_3->addWidget(PT_sendData, 0, 0, 1, 1);

        PB_sendSerialData = new QPushButton(groupBox_2);
        PB_sendSerialData->setObjectName(QString::fromUtf8("PB_sendSerialData"));
        sizePolicy.setHeightForWidth(PB_sendSerialData->sizePolicy().hasHeightForWidth());
        PB_sendSerialData->setSizePolicy(sizePolicy);
        PB_sendSerialData->setMinimumSize(QSize(0, 0));
        PB_sendSerialData->setMaximumSize(QSize(16777215, 16777215));

        gridLayout_3->addWidget(PB_sendSerialData, 1, 0, 1, 1);


        gridLayout_5->addWidget(groupBox_2, 1, 0, 1, 1);

        groupBox_3 = new QGroupBox(SerialCfg);
        groupBox_3->setObjectName(QString::fromUtf8("groupBox_3"));
        gridLayout_4 = new QGridLayout(groupBox_3);
        gridLayout_4->setObjectName(QString::fromUtf8("gridLayout_4"));
        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        verticalLayout_2 = new QVBoxLayout();
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        checkBox_receiveOrNot = new QCheckBox(groupBox_3);
        checkBox_receiveOrNot->setObjectName(QString::fromUtf8("checkBox_receiveOrNot"));

        verticalLayout_2->addWidget(checkBox_receiveOrNot);

        checkBox_dispReceive = new QCheckBox(groupBox_3);
        checkBox_dispReceive->setObjectName(QString::fromUtf8("checkBox_dispReceive"));

        verticalLayout_2->addWidget(checkBox_dispReceive);


        horizontalLayout->addLayout(verticalLayout_2);

        pushButton_clearDisp = new QPushButton(groupBox_3);
        pushButton_clearDisp->setObjectName(QString::fromUtf8("pushButton_clearDisp"));

        horizontalLayout->addWidget(pushButton_clearDisp);


        gridLayout_4->addLayout(horizontalLayout, 1, 0, 1, 1);

        textEdit_showMsg = new QTextEdit(groupBox_3);
        textEdit_showMsg->setObjectName(QString::fromUtf8("textEdit_showMsg"));

        gridLayout_4->addWidget(textEdit_showMsg, 0, 0, 1, 1);


        gridLayout_5->addWidget(groupBox_3, 2, 0, 1, 1);


        retranslateUi(SerialCfg);

        QMetaObject::connectSlotsByName(SerialCfg);
    } // setupUi

    void retranslateUi(QWidget *SerialCfg)
    {
        SerialCfg->setWindowTitle(QApplication::translate("SerialCfg", "SMOS::\344\270\262\345\217\243\351\200\232\344\277\241\351\205\215\347\275\256", nullptr));
        groupBox->setTitle(QApplication::translate("SerialCfg", "\344\270\262\345\217\243\351\205\215\347\275\256", nullptr));
        LB_checkBit->setText(QApplication::translate("SerialCfg", "\346\240\241\351\252\214\344\275\215\357\274\232", nullptr));
        CB_checkBit->setItemText(0, QApplication::translate("SerialCfg", "None", nullptr));
        CB_checkBit->setItemText(1, QApplication::translate("SerialCfg", "Even", nullptr));
        CB_checkBit->setItemText(2, QApplication::translate("SerialCfg", "Mark", nullptr));
        CB_checkBit->setItemText(3, QApplication::translate("SerialCfg", "Odd", nullptr));

        LB_serialPort->setText(QApplication::translate("SerialCfg", "\344\270\262\345\217\243\345\217\267\357\274\232", nullptr));
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
        CB_stopBit->setItemText(0, QApplication::translate("SerialCfg", "1", nullptr));
        CB_stopBit->setItemText(1, QApplication::translate("SerialCfg", "1.5", nullptr));
        CB_stopBit->setItemText(2, QApplication::translate("SerialCfg", "2", nullptr));

        LB_stopBit->setText(QApplication::translate("SerialCfg", "\345\201\234\346\255\242\344\275\215\357\274\232", nullptr));
        LB_baudRate->setText(QApplication::translate("SerialCfg", "\346\263\242\347\211\271\347\216\207\357\274\232", nullptr));
        LB_dataBit->setText(QApplication::translate("SerialCfg", "\346\225\260\346\215\256\344\275\215\357\274\232", nullptr));
        CB_dataBit->setItemText(0, QApplication::translate("SerialCfg", "5", nullptr));
        CB_dataBit->setItemText(1, QApplication::translate("SerialCfg", "6", nullptr));
        CB_dataBit->setItemText(2, QApplication::translate("SerialCfg", "7", nullptr));
        CB_dataBit->setItemText(3, QApplication::translate("SerialCfg", "8", nullptr));

        CB_dataBit->setCurrentText(QApplication::translate("SerialCfg", "5", nullptr));
        PB_openSerial->setText(QApplication::translate("SerialCfg", "\346\211\223\345\274\200/\345\205\263\351\227\255", nullptr));
        label_serialState->setText(QApplication::translate("SerialCfg", "\344\270\262\345\217\243\347\212\266\346\200\201\357\274\232", nullptr));
        groupBox_2->setTitle(QApplication::translate("SerialCfg", "\346\214\207\344\273\244\345\217\221\351\200\201", nullptr));
        PB_sendSerialData->setText(QApplication::translate("SerialCfg", "\345\217\221\351\200\201\346\225\260\346\215\256", nullptr));
        groupBox_3->setTitle(QApplication::translate("SerialCfg", "\346\216\245\346\224\266\346\225\260\346\215\256", nullptr));
        checkBox_receiveOrNot->setText(QApplication::translate("SerialCfg", "\345\274\200\345\220\257\346\216\245\346\224\266", nullptr));
        checkBox_dispReceive->setText(QApplication::translate("SerialCfg", "\346\230\276\347\244\272\346\216\245\346\224\266", nullptr));
        pushButton_clearDisp->setText(QApplication::translate("SerialCfg", "\346\270\205\347\251\272", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SerialCfg: public Ui_SerialCfg {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SERIALCFG_H
