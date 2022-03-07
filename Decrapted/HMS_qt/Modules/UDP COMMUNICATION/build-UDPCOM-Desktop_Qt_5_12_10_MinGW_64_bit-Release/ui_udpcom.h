/********************************************************************************
** Form generated from reading UI file 'udpcom.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_UDPCOM_H
#define UI_UDPCOM_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_UDPCOM
{
public:
    QGridLayout *gridLayout;
    QPushButton *pushButton_sendP2P;
    QTextEdit *textEdit_disp;
    QLabel *label_4;
    QPushButton *pushButton_clearDisp;
    QPushButton *pushButton_bindPort;
    QPushButton *pushButton_abortBind;
    QHBoxLayout *horizontalLayout_3;
    QLabel *label_3;
    QSpinBox *spinBox_targetPort;
    QHBoxLayout *horizontalLayout_2;
    QLabel *label_2;
    QComboBox *comboBox_targetIP;
    QLineEdit *lineEdit_msg2Send;
    QHBoxLayout *horizontalLayout;
    QLabel *label;
    QSpinBox *spinBox_bindPort;
    QPushButton *pushButton_Broadcast;
    QLineEdit *lineEdit_name;
    QLabel *label_socketState;

    void setupUi(QWidget *UDPCOM)
    {
        if (UDPCOM->objectName().isEmpty())
            UDPCOM->setObjectName(QString::fromUtf8("UDPCOM"));
        UDPCOM->resize(550, 450);
        UDPCOM->setMinimumSize(QSize(550, 450));
        UDPCOM->setMaximumSize(QSize(550, 450));
        gridLayout = new QGridLayout(UDPCOM);
        gridLayout->setSpacing(6);
        gridLayout->setContentsMargins(11, 11, 11, 11);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        pushButton_sendP2P = new QPushButton(UDPCOM);
        pushButton_sendP2P->setObjectName(QString::fromUtf8("pushButton_sendP2P"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(20);
        sizePolicy.setHeightForWidth(pushButton_sendP2P->sizePolicy().hasHeightForWidth());
        pushButton_sendP2P->setSizePolicy(sizePolicy);
        pushButton_sendP2P->setMinimumSize(QSize(0, 20));

        gridLayout->addWidget(pushButton_sendP2P, 2, 3, 1, 2);

        textEdit_disp = new QTextEdit(UDPCOM);
        textEdit_disp->setObjectName(QString::fromUtf8("textEdit_disp"));

        gridLayout->addWidget(textEdit_disp, 3, 0, 1, 7);

        label_4 = new QLabel(UDPCOM);
        label_4->setObjectName(QString::fromUtf8("label_4"));
        QSizePolicy sizePolicy1(QSizePolicy::Minimum, QSizePolicy::Minimum);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(label_4->sizePolicy().hasHeightForWidth());
        label_4->setSizePolicy(sizePolicy1);

        gridLayout->addWidget(label_4, 4, 4, 1, 1);

        pushButton_clearDisp = new QPushButton(UDPCOM);
        pushButton_clearDisp->setObjectName(QString::fromUtf8("pushButton_clearDisp"));
        QSizePolicy sizePolicy2(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy2.setHorizontalStretch(0);
        sizePolicy2.setVerticalStretch(0);
        sizePolicy2.setHeightForWidth(pushButton_clearDisp->sizePolicy().hasHeightForWidth());
        pushButton_clearDisp->setSizePolicy(sizePolicy2);
        pushButton_clearDisp->setMinimumSize(QSize(0, 30));
        pushButton_clearDisp->setMaximumSize(QSize(16777215, 30));

        gridLayout->addWidget(pushButton_clearDisp, 0, 4, 1, 3);

        pushButton_bindPort = new QPushButton(UDPCOM);
        pushButton_bindPort->setObjectName(QString::fromUtf8("pushButton_bindPort"));
        sizePolicy2.setHeightForWidth(pushButton_bindPort->sizePolicy().hasHeightForWidth());
        pushButton_bindPort->setSizePolicy(sizePolicy2);
        pushButton_bindPort->setMinimumSize(QSize(0, 30));
        pushButton_bindPort->setMaximumSize(QSize(16777215, 30));

        gridLayout->addWidget(pushButton_bindPort, 0, 0, 1, 1);

        pushButton_abortBind = new QPushButton(UDPCOM);
        pushButton_abortBind->setObjectName(QString::fromUtf8("pushButton_abortBind"));
        sizePolicy2.setHeightForWidth(pushButton_abortBind->sizePolicy().hasHeightForWidth());
        pushButton_abortBind->setSizePolicy(sizePolicy2);
        pushButton_abortBind->setMinimumSize(QSize(0, 30));
        pushButton_abortBind->setMaximumSize(QSize(16777215, 30));

        gridLayout->addWidget(pushButton_abortBind, 0, 1, 1, 3);

        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setObjectName(QString::fromUtf8("horizontalLayout_3"));
        label_3 = new QLabel(UDPCOM);
        label_3->setObjectName(QString::fromUtf8("label_3"));
        QSizePolicy sizePolicy3(QSizePolicy::Fixed, QSizePolicy::Preferred);
        sizePolicy3.setHorizontalStretch(0);
        sizePolicy3.setVerticalStretch(0);
        sizePolicy3.setHeightForWidth(label_3->sizePolicy().hasHeightForWidth());
        label_3->setSizePolicy(sizePolicy3);

        horizontalLayout_3->addWidget(label_3);

        spinBox_targetPort = new QSpinBox(UDPCOM);
        spinBox_targetPort->setObjectName(QString::fromUtf8("spinBox_targetPort"));
        sizePolicy2.setHeightForWidth(spinBox_targetPort->sizePolicy().hasHeightForWidth());
        spinBox_targetPort->setSizePolicy(sizePolicy2);
        spinBox_targetPort->setMinimumSize(QSize(0, 30));
        spinBox_targetPort->setMaximumSize(QSize(16777215, 30));
        spinBox_targetPort->setMaximum(10000);
        spinBox_targetPort->setValue(8848);

        horizontalLayout_3->addWidget(spinBox_targetPort);


        gridLayout->addLayout(horizontalLayout_3, 1, 6, 1, 1);

        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        label_2 = new QLabel(UDPCOM);
        label_2->setObjectName(QString::fromUtf8("label_2"));
        sizePolicy3.setHeightForWidth(label_2->sizePolicy().hasHeightForWidth());
        label_2->setSizePolicy(sizePolicy3);

        horizontalLayout_2->addWidget(label_2);

        comboBox_targetIP = new QComboBox(UDPCOM);
        comboBox_targetIP->setObjectName(QString::fromUtf8("comboBox_targetIP"));
        QSizePolicy sizePolicy4(QSizePolicy::Preferred, QSizePolicy::Fixed);
        sizePolicy4.setHorizontalStretch(0);
        sizePolicy4.setVerticalStretch(0);
        sizePolicy4.setHeightForWidth(comboBox_targetIP->sizePolicy().hasHeightForWidth());
        comboBox_targetIP->setSizePolicy(sizePolicy4);
        comboBox_targetIP->setMinimumSize(QSize(0, 30));
        comboBox_targetIP->setMaximumSize(QSize(16777215, 30));

        horizontalLayout_2->addWidget(comboBox_targetIP);


        gridLayout->addLayout(horizontalLayout_2, 1, 2, 1, 3);

        lineEdit_msg2Send = new QLineEdit(UDPCOM);
        lineEdit_msg2Send->setObjectName(QString::fromUtf8("lineEdit_msg2Send"));

        gridLayout->addWidget(lineEdit_msg2Send, 2, 0, 1, 3);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        label = new QLabel(UDPCOM);
        label->setObjectName(QString::fromUtf8("label"));
        sizePolicy3.setHeightForWidth(label->sizePolicy().hasHeightForWidth());
        label->setSizePolicy(sizePolicy3);

        horizontalLayout->addWidget(label);

        spinBox_bindPort = new QSpinBox(UDPCOM);
        spinBox_bindPort->setObjectName(QString::fromUtf8("spinBox_bindPort"));
        sizePolicy2.setHeightForWidth(spinBox_bindPort->sizePolicy().hasHeightForWidth());
        spinBox_bindPort->setSizePolicy(sizePolicy2);
        spinBox_bindPort->setMinimumSize(QSize(0, 30));
        spinBox_bindPort->setMaximumSize(QSize(16777215, 30));
        spinBox_bindPort->setMaximum(10000);
        spinBox_bindPort->setValue(2333);

        horizontalLayout->addWidget(spinBox_bindPort);


        gridLayout->addLayout(horizontalLayout, 1, 0, 1, 2);

        pushButton_Broadcast = new QPushButton(UDPCOM);
        pushButton_Broadcast->setObjectName(QString::fromUtf8("pushButton_Broadcast"));
        sizePolicy.setHeightForWidth(pushButton_Broadcast->sizePolicy().hasHeightForWidth());
        pushButton_Broadcast->setSizePolicy(sizePolicy);
        pushButton_Broadcast->setMinimumSize(QSize(0, 20));

        gridLayout->addWidget(pushButton_Broadcast, 2, 6, 1, 1);

        lineEdit_name = new QLineEdit(UDPCOM);
        lineEdit_name->setObjectName(QString::fromUtf8("lineEdit_name"));
        lineEdit_name->setMinimumSize(QSize(0, 20));
        lineEdit_name->setMaximumSize(QSize(16777215, 20));

        gridLayout->addWidget(lineEdit_name, 4, 6, 1, 1);

        label_socketState = new QLabel(UDPCOM);
        label_socketState->setObjectName(QString::fromUtf8("label_socketState"));
        QSizePolicy sizePolicy5(QSizePolicy::Expanding, QSizePolicy::Minimum);
        sizePolicy5.setHorizontalStretch(0);
        sizePolicy5.setVerticalStretch(0);
        sizePolicy5.setHeightForWidth(label_socketState->sizePolicy().hasHeightForWidth());
        label_socketState->setSizePolicy(sizePolicy5);
        label_socketState->setMinimumSize(QSize(0, 20));
        label_socketState->setMaximumSize(QSize(16777215, 20));

        gridLayout->addWidget(label_socketState, 4, 0, 1, 4);


        retranslateUi(UDPCOM);

        QMetaObject::connectSlotsByName(UDPCOM);
    } // setupUi

    void retranslateUi(QWidget *UDPCOM)
    {
        UDPCOM->setWindowTitle(QApplication::translate("UDPCOM", "UDPCOM", nullptr));
        pushButton_sendP2P->setText(QApplication::translate("UDPCOM", "\345\217\221\351\200\201\346\266\210\346\201\257", nullptr));
        label_4->setText(QApplication::translate("UDPCOM", "\346\230\265\347\247\260", nullptr));
        pushButton_clearDisp->setText(QApplication::translate("UDPCOM", "\346\270\205\347\251\272\346\266\210\346\201\257", nullptr));
        pushButton_bindPort->setText(QApplication::translate("UDPCOM", "\347\273\221\345\256\232\347\253\257\345\217\243", nullptr));
        pushButton_abortBind->setText(QApplication::translate("UDPCOM", "\350\247\243\351\231\244\347\273\221\345\256\232", nullptr));
        label_3->setText(QApplication::translate("UDPCOM", "\347\233\256\346\240\207\347\253\257\345\217\243", nullptr));
        label_2->setText(QApplication::translate("UDPCOM", "\347\233\256\346\240\207IP", nullptr));
        label->setText(QApplication::translate("UDPCOM", "\347\273\221\345\256\232\347\253\257\345\217\243", nullptr));
        pushButton_Broadcast->setText(QApplication::translate("UDPCOM", "\345\271\277\346\222\255\346\266\210\346\201\257", nullptr));
        lineEdit_name->setText(QApplication::translate("UDPCOM", "NULL", nullptr));
        label_socketState->setText(QApplication::translate("UDPCOM", "Socket State", nullptr));
    } // retranslateUi

};

namespace Ui {
    class UDPCOM: public Ui_UDPCOM {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_UDPCOM_H
