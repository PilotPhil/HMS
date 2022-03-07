/********************************************************************************
** Form generated from reading UI file 'fatigue.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_FATIGUE_H
#define UI_FATIGUE_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QDoubleSpinBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_FATIGUE
{
public:
    QGridLayout *gridLayout_4;
    QGroupBox *groupBox;
    QGridLayout *gridLayout;
    QLabel *label_2;
    QLabel *label;
    QCheckBox *CB_rawData;
    QDoubleSpinBox *doubleSpinBox;
    QSpacerItem *horizontalSpacer;
    QCheckBox *CB_peakVally;
    QComboBox *comboBox;
    QPushButton *PB_reCompute;
    QHBoxLayout *horizontalLayout;
    QGroupBox *groupBox_2;
    QGridLayout *gridLayout_2;
    QPushButton *PB_inputData;
    QLineEdit *LE_address;
    QGroupBox *groupBox_3;
    QGridLayout *gridLayout_3;
    QLineEdit *LE_damage;
    QWidget *WG_chart;
    QWidget *WG_table;

    void setupUi(QWidget *FATIGUE)
    {
        if (FATIGUE->objectName().isEmpty())
            FATIGUE->setObjectName(QString::fromUtf8("FATIGUE"));
        FATIGUE->resize(815, 572);
        gridLayout_4 = new QGridLayout(FATIGUE);
        gridLayout_4->setSpacing(6);
        gridLayout_4->setContentsMargins(11, 11, 11, 11);
        gridLayout_4->setObjectName(QString::fromUtf8("gridLayout_4"));
        groupBox = new QGroupBox(FATIGUE);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        gridLayout = new QGridLayout(groupBox);
        gridLayout->setSpacing(6);
        gridLayout->setContentsMargins(11, 11, 11, 11);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        label_2 = new QLabel(groupBox);
        label_2->setObjectName(QString::fromUtf8("label_2"));

        gridLayout->addWidget(label_2, 0, 5, 1, 1);

        label = new QLabel(groupBox);
        label->setObjectName(QString::fromUtf8("label"));

        gridLayout->addWidget(label, 0, 3, 1, 1);

        CB_rawData = new QCheckBox(groupBox);
        CB_rawData->setObjectName(QString::fromUtf8("CB_rawData"));

        gridLayout->addWidget(CB_rawData, 0, 0, 1, 1);

        doubleSpinBox = new QDoubleSpinBox(groupBox);
        doubleSpinBox->setObjectName(QString::fromUtf8("doubleSpinBox"));
        doubleSpinBox->setMaximum(1000.000000000000000);
        doubleSpinBox->setValue(235.000000000000000);

        gridLayout->addWidget(doubleSpinBox, 0, 6, 1, 1);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout->addItem(horizontalSpacer, 0, 2, 1, 1);

        CB_peakVally = new QCheckBox(groupBox);
        CB_peakVally->setObjectName(QString::fromUtf8("CB_peakVally"));

        gridLayout->addWidget(CB_peakVally, 0, 1, 1, 1);

        comboBox = new QComboBox(groupBox);
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->setObjectName(QString::fromUtf8("comboBox"));

        gridLayout->addWidget(comboBox, 0, 4, 1, 1);

        PB_reCompute = new QPushButton(groupBox);
        PB_reCompute->setObjectName(QString::fromUtf8("PB_reCompute"));

        gridLayout->addWidget(PB_reCompute, 0, 7, 1, 1);


        gridLayout_4->addWidget(groupBox, 0, 0, 1, 2);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        groupBox_2 = new QGroupBox(FATIGUE);
        groupBox_2->setObjectName(QString::fromUtf8("groupBox_2"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Preferred);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(groupBox_2->sizePolicy().hasHeightForWidth());
        groupBox_2->setSizePolicy(sizePolicy);
        gridLayout_2 = new QGridLayout(groupBox_2);
        gridLayout_2->setSpacing(6);
        gridLayout_2->setContentsMargins(11, 11, 11, 11);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        PB_inputData = new QPushButton(groupBox_2);
        PB_inputData->setObjectName(QString::fromUtf8("PB_inputData"));

        gridLayout_2->addWidget(PB_inputData, 0, 0, 1, 1);

        LE_address = new QLineEdit(groupBox_2);
        LE_address->setObjectName(QString::fromUtf8("LE_address"));

        gridLayout_2->addWidget(LE_address, 0, 1, 1, 1);


        horizontalLayout->addWidget(groupBox_2);

        groupBox_3 = new QGroupBox(FATIGUE);
        groupBox_3->setObjectName(QString::fromUtf8("groupBox_3"));
        sizePolicy.setHeightForWidth(groupBox_3->sizePolicy().hasHeightForWidth());
        groupBox_3->setSizePolicy(sizePolicy);
        groupBox_3->setMaximumSize(QSize(180, 16777215));
        gridLayout_3 = new QGridLayout(groupBox_3);
        gridLayout_3->setSpacing(6);
        gridLayout_3->setContentsMargins(11, 11, 11, 11);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        LE_damage = new QLineEdit(groupBox_3);
        LE_damage->setObjectName(QString::fromUtf8("LE_damage"));

        gridLayout_3->addWidget(LE_damage, 0, 0, 1, 1);


        horizontalLayout->addWidget(groupBox_3);


        gridLayout_4->addLayout(horizontalLayout, 1, 0, 1, 2);

        WG_chart = new QWidget(FATIGUE);
        WG_chart->setObjectName(QString::fromUtf8("WG_chart"));
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Expanding);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(WG_chart->sizePolicy().hasHeightForWidth());
        WG_chart->setSizePolicy(sizePolicy1);

        gridLayout_4->addWidget(WG_chart, 2, 0, 1, 1);

        WG_table = new QWidget(FATIGUE);
        WG_table->setObjectName(QString::fromUtf8("WG_table"));
        sizePolicy1.setHeightForWidth(WG_table->sizePolicy().hasHeightForWidth());
        WG_table->setSizePolicy(sizePolicy1);
        WG_table->setMaximumSize(QSize(700, 16777215));

        gridLayout_4->addWidget(WG_table, 2, 1, 1, 1);


        retranslateUi(FATIGUE);

        QMetaObject::connectSlotsByName(FATIGUE);
    } // setupUi

    void retranslateUi(QWidget *FATIGUE)
    {
        FATIGUE->setWindowTitle(QApplication::translate("FATIGUE", "FATIGUE", nullptr));
        groupBox->setTitle(QApplication::translate("FATIGUE", "\350\256\276\347\275\256", nullptr));
        label_2->setText(QApplication::translate("FATIGUE", "\345\261\210\346\234\215\345\272\224\345\212\233", nullptr));
        label->setText(QApplication::translate("FATIGUE", "SN\346\233\262\347\272\277", nullptr));
        CB_rawData->setText(QApplication::translate("FATIGUE", "RawData", nullptr));
        CB_peakVally->setText(QApplication::translate("FATIGUE", "PeakVally", nullptr));
        comboBox->setItemText(0, QApplication::translate("FATIGUE", "B", nullptr));
        comboBox->setItemText(1, QApplication::translate("FATIGUE", "C", nullptr));
        comboBox->setItemText(2, QApplication::translate("FATIGUE", "D", nullptr));
        comboBox->setItemText(3, QApplication::translate("FATIGUE", "E", nullptr));
        comboBox->setItemText(4, QApplication::translate("FATIGUE", "F", nullptr));
        comboBox->setItemText(5, QApplication::translate("FATIGUE", "F2", nullptr));
        comboBox->setItemText(6, QApplication::translate("FATIGUE", "G", nullptr));
        comboBox->setItemText(7, QApplication::translate("FATIGUE", "W", nullptr));

        PB_reCompute->setText(QApplication::translate("FATIGUE", "\351\207\215\346\226\260\350\256\241\347\256\227", nullptr));
        groupBox_2->setTitle(QApplication::translate("FATIGUE", "\346\211\223\345\274\200\346\226\207\344\273\266", nullptr));
        PB_inputData->setText(QApplication::translate("FATIGUE", "\345\257\274\345\205\245\346\225\260\346\215\256", nullptr));
        groupBox_3->setTitle(QApplication::translate("FATIGUE", "\347\226\262\345\212\263\346\215\237\344\274\244", nullptr));
    } // retranslateUi

};

namespace Ui {
    class FATIGUE: public Ui_FATIGUE {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_FATIGUE_H
