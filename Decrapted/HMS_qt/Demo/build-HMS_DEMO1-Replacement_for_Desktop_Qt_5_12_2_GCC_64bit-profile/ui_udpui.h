/********************************************************************************
** Form generated from reading UI file 'udpui.ui'
**
** Created by: Qt User Interface Compiler version 5.12.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_UDPUI_H
#define UI_UDPUI_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_UDPUI
{
public:
    QVBoxLayout *verticalLayout;
    QGroupBox *groupBox;
    QGridLayout *gridLayout_4;
    QGridLayout *gridLayout;
    QLabel *label;
    QSpinBox *spinBox_localPort;
    QLabel *label_2;
    QSpinBox *spinBox_targetPort;
    QLabel *label_3;
    QComboBox *comboBox_targetIp;
    QPushButton *pushButton_bindorAbort;
    QLabel *label_socketState;
    QGroupBox *groupBox_2;
    QGridLayout *gridLayout_2;
    QTextEdit *textEdit_msg2send;
    QPushButton *pushButton_send;
    QGroupBox *groupBox_3;
    QGridLayout *gridLayout_3;
    QTextEdit *textEdit_receivedMsg;
    QHBoxLayout *horizontalLayout;
    QVBoxLayout *verticalLayout_2;
    QCheckBox *checkBox_receiveOrNot;
    QCheckBox *checkBox_dispReceive;
    QPushButton *pushButton_clearDisp;

    void setupUi(QWidget *UDPUI)
    {
        if (UDPUI->objectName().isEmpty())
            UDPUI->setObjectName(QString::fromUtf8("UDPUI"));
        UDPUI->resize(327, 578);
        verticalLayout = new QVBoxLayout(UDPUI);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        groupBox = new QGroupBox(UDPUI);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        gridLayout_4 = new QGridLayout(groupBox);
        gridLayout_4->setObjectName(QString::fromUtf8("gridLayout_4"));
        gridLayout = new QGridLayout();
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        label = new QLabel(groupBox);
        label->setObjectName(QString::fromUtf8("label"));
        QSizePolicy sizePolicy(QSizePolicy::Fixed, QSizePolicy::Preferred);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(label->sizePolicy().hasHeightForWidth());
        label->setSizePolicy(sizePolicy);

        gridLayout->addWidget(label, 0, 0, 1, 1);

        spinBox_localPort = new QSpinBox(groupBox);
        spinBox_localPort->setObjectName(QString::fromUtf8("spinBox_localPort"));
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(spinBox_localPort->sizePolicy().hasHeightForWidth());
        spinBox_localPort->setSizePolicy(sizePolicy1);
        spinBox_localPort->setMaximum(999999);
        spinBox_localPort->setValue(8848);

        gridLayout->addWidget(spinBox_localPort, 0, 1, 1, 1);

        label_2 = new QLabel(groupBox);
        label_2->setObjectName(QString::fromUtf8("label_2"));
        sizePolicy.setHeightForWidth(label_2->sizePolicy().hasHeightForWidth());
        label_2->setSizePolicy(sizePolicy);

        gridLayout->addWidget(label_2, 1, 0, 1, 1);

        spinBox_targetPort = new QSpinBox(groupBox);
        spinBox_targetPort->setObjectName(QString::fromUtf8("spinBox_targetPort"));
        sizePolicy1.setHeightForWidth(spinBox_targetPort->sizePolicy().hasHeightForWidth());
        spinBox_targetPort->setSizePolicy(sizePolicy1);
        spinBox_targetPort->setMaximum(999999);
        spinBox_targetPort->setValue(2333);

        gridLayout->addWidget(spinBox_targetPort, 1, 1, 1, 1);

        label_3 = new QLabel(groupBox);
        label_3->setObjectName(QString::fromUtf8("label_3"));
        sizePolicy.setHeightForWidth(label_3->sizePolicy().hasHeightForWidth());
        label_3->setSizePolicy(sizePolicy);

        gridLayout->addWidget(label_3, 2, 0, 1, 1);

        comboBox_targetIp = new QComboBox(groupBox);
        comboBox_targetIp->setObjectName(QString::fromUtf8("comboBox_targetIp"));

        gridLayout->addWidget(comboBox_targetIp, 2, 1, 1, 1);

        pushButton_bindorAbort = new QPushButton(groupBox);
        pushButton_bindorAbort->setObjectName(QString::fromUtf8("pushButton_bindorAbort"));
        pushButton_bindorAbort->setCheckable(true);

        gridLayout->addWidget(pushButton_bindorAbort, 3, 1, 1, 1);


        gridLayout_4->addLayout(gridLayout, 0, 0, 1, 1);

        label_socketState = new QLabel(groupBox);
        label_socketState->setObjectName(QString::fromUtf8("label_socketState"));

        gridLayout_4->addWidget(label_socketState, 1, 0, 1, 1);


        verticalLayout->addWidget(groupBox);

        groupBox_2 = new QGroupBox(UDPUI);
        groupBox_2->setObjectName(QString::fromUtf8("groupBox_2"));
        gridLayout_2 = new QGridLayout(groupBox_2);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        textEdit_msg2send = new QTextEdit(groupBox_2);
        textEdit_msg2send->setObjectName(QString::fromUtf8("textEdit_msg2send"));

        gridLayout_2->addWidget(textEdit_msg2send, 0, 0, 1, 1);

        pushButton_send = new QPushButton(groupBox_2);
        pushButton_send->setObjectName(QString::fromUtf8("pushButton_send"));

        gridLayout_2->addWidget(pushButton_send, 1, 0, 1, 1);


        verticalLayout->addWidget(groupBox_2);

        groupBox_3 = new QGroupBox(UDPUI);
        groupBox_3->setObjectName(QString::fromUtf8("groupBox_3"));
        gridLayout_3 = new QGridLayout(groupBox_3);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        textEdit_receivedMsg = new QTextEdit(groupBox_3);
        textEdit_receivedMsg->setObjectName(QString::fromUtf8("textEdit_receivedMsg"));

        gridLayout_3->addWidget(textEdit_receivedMsg, 0, 0, 1, 1);

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


        gridLayout_3->addLayout(horizontalLayout, 1, 0, 1, 1);


        verticalLayout->addWidget(groupBox_3);


        retranslateUi(UDPUI);

        QMetaObject::connectSlotsByName(UDPUI);
    } // setupUi

    void retranslateUi(QWidget *UDPUI)
    {
        UDPUI->setWindowTitle(QApplication::translate("UDPUI", "Form", nullptr));
        groupBox->setTitle(QApplication::translate("UDPUI", "UDP\351\205\215\347\275\256", nullptr));
        label->setText(QApplication::translate("UDPUI", "\346\234\254\345\234\260\347\253\257\345\217\243", nullptr));
        label_2->setText(QApplication::translate("UDPUI", "\347\233\256\346\240\207\347\253\257\345\217\243", nullptr));
        label_3->setText(QApplication::translate("UDPUI", "\347\233\256\346\240\207IP", nullptr));
        pushButton_bindorAbort->setText(QApplication::translate("UDPUI", "\347\273\221\345\256\232/\350\247\243\347\273\221", nullptr));
        label_socketState->setText(QApplication::translate("UDPUI", "Socket \347\212\266\346\200\201\357\274\232", nullptr));
        groupBox_2->setTitle(QApplication::translate("UDPUI", "\346\214\207\344\273\244\345\217\221\351\200\201", nullptr));
        pushButton_send->setText(QApplication::translate("UDPUI", "\345\217\221\351\200\201", nullptr));
        groupBox_3->setTitle(QApplication::translate("UDPUI", "\346\216\245\346\224\266\346\225\260\346\215\256", nullptr));
        checkBox_receiveOrNot->setText(QApplication::translate("UDPUI", "\345\274\200\345\220\257\346\216\245\346\224\266", nullptr));
        checkBox_dispReceive->setText(QApplication::translate("UDPUI", "\346\230\276\347\244\272\346\216\245\346\224\266", nullptr));
        pushButton_clearDisp->setText(QApplication::translate("UDPUI", "\346\270\205\347\251\272", nullptr));
    } // retranslateUi

};

namespace Ui {
    class UDPUI: public Ui_UDPUI {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_UDPUI_H
