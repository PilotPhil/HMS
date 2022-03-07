/********************************************************************************
** Form generated from reading UI file 'adcform.ui'
**
** Created by: Qt User Interface Compiler version 5.12.11
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_ADCFORM_H
#define UI_ADCFORM_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_AdcForm
{
public:
    QVBoxLayout *verticalLayout;
    QGroupBox *groupBox;
    QGridLayout *gridLayout_2;
    QComboBox *cmb_mode;
    QComboBox *cmb_drates;
    QPushButton *pb_setCfg;
    QPushButton *pb_start;
    QLabel *label_2;
    QComboBox *cmb_gain;
    QLabel *label;
    QLabel *label_3;
    QTextEdit *te_toStress;
    QLabel *label_20;
    QGroupBox *groupBox_2;
    QGridLayout *gridLayout_3;
    QCheckBox *cb_use4;
    QTextEdit *te_stress_2;
    QTextEdit *te_5;
    QTextEdit *te_stress_5;
    QTextEdit *te_4;
    QTextEdit *te_stress_1;
    QLabel *label_8;
    QLabel *label_10;
    QCheckBox *cb_use2;
    QLabel *label_11;
    QCheckBox *cb_use0;
    QCheckBox *cb_use6;
    QCheckBox *cb_use7;
    QTextEdit *te_2;
    QTextEdit *te_stress_6;
    QTextEdit *te_stress_7;
    QTextEdit *te_stress_0;
    QTextEdit *te_3;
    QLabel *label_6;
    QTextEdit *te_7;
    QTextEdit *te_1;
    QTextEdit *te_stress_4;
    QTextEdit *te_stress_3;
    QCheckBox *cb_use1;
    QTextEdit *te_6;
    QCheckBox *cb_use5;
    QCheckBox *cb_use3;
    QLabel *label_9;
    QLabel *label_4;
    QLabel *label_5;
    QLabel *label_7;
    QTextEdit *te_0;
    QLabel *label_12;
    QLabel *label_13;
    QLabel *label_14;
    QLabel *label_15;
    QLabel *label_16;
    QLabel *label_17;
    QLabel *label_18;
    QLabel *label_19;

    void setupUi(QWidget *AdcForm)
    {
        if (AdcForm->objectName().isEmpty())
            AdcForm->setObjectName(QString::fromUtf8("AdcForm"));
        AdcForm->resize(495, 570);
        verticalLayout = new QVBoxLayout(AdcForm);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        groupBox = new QGroupBox(AdcForm);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        gridLayout_2 = new QGridLayout(groupBox);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        cmb_mode = new QComboBox(groupBox);
        cmb_mode->addItem(QString());
        cmb_mode->addItem(QString());
        cmb_mode->setObjectName(QString::fromUtf8("cmb_mode"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(cmb_mode->sizePolicy().hasHeightForWidth());
        cmb_mode->setSizePolicy(sizePolicy);

        gridLayout_2->addWidget(cmb_mode, 0, 1, 1, 1);

        cmb_drates = new QComboBox(groupBox);
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->addItem(QString());
        cmb_drates->setObjectName(QString::fromUtf8("cmb_drates"));
        sizePolicy.setHeightForWidth(cmb_drates->sizePolicy().hasHeightForWidth());
        cmb_drates->setSizePolicy(sizePolicy);

        gridLayout_2->addWidget(cmb_drates, 4, 1, 1, 1);

        pb_setCfg = new QPushButton(groupBox);
        pb_setCfg->setObjectName(QString::fromUtf8("pb_setCfg"));
        QFont font;
        font.setPointSize(16);
        font.setBold(true);
        font.setItalic(true);
        font.setWeight(75);
        pb_setCfg->setFont(font);
        pb_setCfg->setCheckable(false);

        gridLayout_2->addWidget(pb_setCfg, 6, 0, 1, 1);

        pb_start = new QPushButton(groupBox);
        pb_start->setObjectName(QString::fromUtf8("pb_start"));
        pb_start->setFont(font);
        pb_start->setCheckable(true);

        gridLayout_2->addWidget(pb_start, 6, 1, 1, 1);

        label_2 = new QLabel(groupBox);
        label_2->setObjectName(QString::fromUtf8("label_2"));
        QSizePolicy sizePolicy1(QSizePolicy::Minimum, QSizePolicy::Preferred);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(label_2->sizePolicy().hasHeightForWidth());
        label_2->setSizePolicy(sizePolicy1);
        QFont font1;
        font1.setFamily(QString::fromUtf8("PibotoLt"));
        font1.setPointSize(16);
        font1.setBold(true);
        font1.setItalic(true);
        font1.setWeight(75);
        label_2->setFont(font1);

        gridLayout_2->addWidget(label_2, 4, 0, 1, 1);

        cmb_gain = new QComboBox(groupBox);
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->addItem(QString());
        cmb_gain->setObjectName(QString::fromUtf8("cmb_gain"));
        sizePolicy.setHeightForWidth(cmb_gain->sizePolicy().hasHeightForWidth());
        cmb_gain->setSizePolicy(sizePolicy);

        gridLayout_2->addWidget(cmb_gain, 2, 1, 1, 1);

        label = new QLabel(groupBox);
        label->setObjectName(QString::fromUtf8("label"));
        sizePolicy1.setHeightForWidth(label->sizePolicy().hasHeightForWidth());
        label->setSizePolicy(sizePolicy1);
        label->setFont(font1);

        gridLayout_2->addWidget(label, 2, 0, 1, 1);

        label_3 = new QLabel(groupBox);
        label_3->setObjectName(QString::fromUtf8("label_3"));
        sizePolicy1.setHeightForWidth(label_3->sizePolicy().hasHeightForWidth());
        label_3->setSizePolicy(sizePolicy1);
        label_3->setFont(font1);

        gridLayout_2->addWidget(label_3, 0, 0, 1, 1);

        te_toStress = new QTextEdit(groupBox);
        te_toStress->setObjectName(QString::fromUtf8("te_toStress"));
        sizePolicy.setHeightForWidth(te_toStress->sizePolicy().hasHeightForWidth());
        te_toStress->setSizePolicy(sizePolicy);
        te_toStress->setMinimumSize(QSize(0, 33));
        te_toStress->setMaximumSize(QSize(16777215, 33));

        gridLayout_2->addWidget(te_toStress, 5, 1, 1, 1);

        label_20 = new QLabel(groupBox);
        label_20->setObjectName(QString::fromUtf8("label_20"));
        sizePolicy1.setHeightForWidth(label_20->sizePolicy().hasHeightForWidth());
        label_20->setSizePolicy(sizePolicy1);
        label_20->setFont(font1);

        gridLayout_2->addWidget(label_20, 5, 0, 1, 1);


        verticalLayout->addWidget(groupBox);

        groupBox_2 = new QGroupBox(AdcForm);
        groupBox_2->setObjectName(QString::fromUtf8("groupBox_2"));
        gridLayout_3 = new QGridLayout(groupBox_2);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        cb_use4 = new QCheckBox(groupBox_2);
        cb_use4->setObjectName(QString::fromUtf8("cb_use4"));
        cb_use4->setChecked(true);

        gridLayout_3->addWidget(cb_use4, 4, 0, 1, 1);

        te_stress_2 = new QTextEdit(groupBox_2);
        te_stress_2->setObjectName(QString::fromUtf8("te_stress_2"));
        sizePolicy.setHeightForWidth(te_stress_2->sizePolicy().hasHeightForWidth());
        te_stress_2->setSizePolicy(sizePolicy);
        te_stress_2->setMinimumSize(QSize(0, 33));
        te_stress_2->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_2, 2, 4, 1, 1);

        te_5 = new QTextEdit(groupBox_2);
        te_5->setObjectName(QString::fromUtf8("te_5"));
        sizePolicy.setHeightForWidth(te_5->sizePolicy().hasHeightForWidth());
        te_5->setSizePolicy(sizePolicy);
        te_5->setMinimumSize(QSize(0, 33));
        te_5->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_5, 5, 1, 1, 1);

        te_stress_5 = new QTextEdit(groupBox_2);
        te_stress_5->setObjectName(QString::fromUtf8("te_stress_5"));
        sizePolicy.setHeightForWidth(te_stress_5->sizePolicy().hasHeightForWidth());
        te_stress_5->setSizePolicy(sizePolicy);
        te_stress_5->setMinimumSize(QSize(0, 33));
        te_stress_5->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_5, 5, 4, 1, 1);

        te_4 = new QTextEdit(groupBox_2);
        te_4->setObjectName(QString::fromUtf8("te_4"));
        sizePolicy.setHeightForWidth(te_4->sizePolicy().hasHeightForWidth());
        te_4->setSizePolicy(sizePolicy);
        te_4->setMinimumSize(QSize(0, 33));
        te_4->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_4, 4, 1, 1, 1);

        te_stress_1 = new QTextEdit(groupBox_2);
        te_stress_1->setObjectName(QString::fromUtf8("te_stress_1"));
        sizePolicy.setHeightForWidth(te_stress_1->sizePolicy().hasHeightForWidth());
        te_stress_1->setSizePolicy(sizePolicy);
        te_stress_1->setMinimumSize(QSize(0, 33));
        te_stress_1->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_1, 1, 4, 1, 1);

        label_8 = new QLabel(groupBox_2);
        label_8->setObjectName(QString::fromUtf8("label_8"));
        sizePolicy1.setHeightForWidth(label_8->sizePolicy().hasHeightForWidth());
        label_8->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_8, 4, 3, 1, 1);

        label_10 = new QLabel(groupBox_2);
        label_10->setObjectName(QString::fromUtf8("label_10"));
        sizePolicy1.setHeightForWidth(label_10->sizePolicy().hasHeightForWidth());
        label_10->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_10, 6, 3, 1, 1);

        cb_use2 = new QCheckBox(groupBox_2);
        cb_use2->setObjectName(QString::fromUtf8("cb_use2"));
        cb_use2->setChecked(true);

        gridLayout_3->addWidget(cb_use2, 2, 0, 1, 1);

        label_11 = new QLabel(groupBox_2);
        label_11->setObjectName(QString::fromUtf8("label_11"));
        sizePolicy1.setHeightForWidth(label_11->sizePolicy().hasHeightForWidth());
        label_11->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_11, 7, 3, 1, 1);

        cb_use0 = new QCheckBox(groupBox_2);
        cb_use0->setObjectName(QString::fromUtf8("cb_use0"));
        cb_use0->setChecked(true);

        gridLayout_3->addWidget(cb_use0, 0, 0, 1, 1);

        cb_use6 = new QCheckBox(groupBox_2);
        cb_use6->setObjectName(QString::fromUtf8("cb_use6"));
        cb_use6->setChecked(true);

        gridLayout_3->addWidget(cb_use6, 6, 0, 1, 1);

        cb_use7 = new QCheckBox(groupBox_2);
        cb_use7->setObjectName(QString::fromUtf8("cb_use7"));
        cb_use7->setChecked(true);

        gridLayout_3->addWidget(cb_use7, 7, 0, 1, 1);

        te_2 = new QTextEdit(groupBox_2);
        te_2->setObjectName(QString::fromUtf8("te_2"));
        sizePolicy.setHeightForWidth(te_2->sizePolicy().hasHeightForWidth());
        te_2->setSizePolicy(sizePolicy);
        te_2->setMinimumSize(QSize(0, 33));
        te_2->setMaximumSize(QSize(16777215, 33));
        QFont font2;
        font2.setPointSize(16);
        font2.setBold(false);
        font2.setItalic(false);
        font2.setWeight(50);
        te_2->setFont(font2);

        gridLayout_3->addWidget(te_2, 2, 1, 1, 1);

        te_stress_6 = new QTextEdit(groupBox_2);
        te_stress_6->setObjectName(QString::fromUtf8("te_stress_6"));
        sizePolicy.setHeightForWidth(te_stress_6->sizePolicy().hasHeightForWidth());
        te_stress_6->setSizePolicy(sizePolicy);
        te_stress_6->setMinimumSize(QSize(0, 33));
        te_stress_6->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_6, 6, 4, 1, 1);

        te_stress_7 = new QTextEdit(groupBox_2);
        te_stress_7->setObjectName(QString::fromUtf8("te_stress_7"));
        sizePolicy.setHeightForWidth(te_stress_7->sizePolicy().hasHeightForWidth());
        te_stress_7->setSizePolicy(sizePolicy);
        te_stress_7->setMinimumSize(QSize(0, 33));
        te_stress_7->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_7, 7, 4, 1, 1);

        te_stress_0 = new QTextEdit(groupBox_2);
        te_stress_0->setObjectName(QString::fromUtf8("te_stress_0"));
        sizePolicy.setHeightForWidth(te_stress_0->sizePolicy().hasHeightForWidth());
        te_stress_0->setSizePolicy(sizePolicy);
        te_stress_0->setMinimumSize(QSize(0, 33));
        te_stress_0->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_0, 0, 4, 1, 1);

        te_3 = new QTextEdit(groupBox_2);
        te_3->setObjectName(QString::fromUtf8("te_3"));
        sizePolicy.setHeightForWidth(te_3->sizePolicy().hasHeightForWidth());
        te_3->setSizePolicy(sizePolicy);
        te_3->setMinimumSize(QSize(0, 33));
        te_3->setMaximumSize(QSize(16777215, 33));
        te_3->setFont(font2);

        gridLayout_3->addWidget(te_3, 3, 1, 1, 1);

        label_6 = new QLabel(groupBox_2);
        label_6->setObjectName(QString::fromUtf8("label_6"));
        sizePolicy1.setHeightForWidth(label_6->sizePolicy().hasHeightForWidth());
        label_6->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_6, 2, 3, 1, 1);

        te_7 = new QTextEdit(groupBox_2);
        te_7->setObjectName(QString::fromUtf8("te_7"));
        sizePolicy.setHeightForWidth(te_7->sizePolicy().hasHeightForWidth());
        te_7->setSizePolicy(sizePolicy);
        te_7->setMinimumSize(QSize(0, 33));
        te_7->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_7, 7, 1, 1, 1);

        te_1 = new QTextEdit(groupBox_2);
        te_1->setObjectName(QString::fromUtf8("te_1"));
        sizePolicy.setHeightForWidth(te_1->sizePolicy().hasHeightForWidth());
        te_1->setSizePolicy(sizePolicy);
        te_1->setMinimumSize(QSize(0, 33));
        te_1->setMaximumSize(QSize(16777215, 33));
        te_1->setFont(font2);

        gridLayout_3->addWidget(te_1, 1, 1, 1, 1);

        te_stress_4 = new QTextEdit(groupBox_2);
        te_stress_4->setObjectName(QString::fromUtf8("te_stress_4"));
        sizePolicy.setHeightForWidth(te_stress_4->sizePolicy().hasHeightForWidth());
        te_stress_4->setSizePolicy(sizePolicy);
        te_stress_4->setMinimumSize(QSize(0, 33));
        te_stress_4->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_4, 4, 4, 1, 1);

        te_stress_3 = new QTextEdit(groupBox_2);
        te_stress_3->setObjectName(QString::fromUtf8("te_stress_3"));
        sizePolicy.setHeightForWidth(te_stress_3->sizePolicy().hasHeightForWidth());
        te_stress_3->setSizePolicy(sizePolicy);
        te_stress_3->setMinimumSize(QSize(0, 33));
        te_stress_3->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_stress_3, 3, 4, 1, 1);

        cb_use1 = new QCheckBox(groupBox_2);
        cb_use1->setObjectName(QString::fromUtf8("cb_use1"));
        cb_use1->setChecked(true);

        gridLayout_3->addWidget(cb_use1, 1, 0, 1, 1);

        te_6 = new QTextEdit(groupBox_2);
        te_6->setObjectName(QString::fromUtf8("te_6"));
        sizePolicy.setHeightForWidth(te_6->sizePolicy().hasHeightForWidth());
        te_6->setSizePolicy(sizePolicy);
        te_6->setMinimumSize(QSize(0, 33));
        te_6->setMaximumSize(QSize(16777215, 33));

        gridLayout_3->addWidget(te_6, 6, 1, 1, 1);

        cb_use5 = new QCheckBox(groupBox_2);
        cb_use5->setObjectName(QString::fromUtf8("cb_use5"));
        cb_use5->setChecked(true);

        gridLayout_3->addWidget(cb_use5, 5, 0, 1, 1);

        cb_use3 = new QCheckBox(groupBox_2);
        cb_use3->setObjectName(QString::fromUtf8("cb_use3"));
        cb_use3->setChecked(true);

        gridLayout_3->addWidget(cb_use3, 3, 0, 1, 1);

        label_9 = new QLabel(groupBox_2);
        label_9->setObjectName(QString::fromUtf8("label_9"));
        sizePolicy1.setHeightForWidth(label_9->sizePolicy().hasHeightForWidth());
        label_9->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_9, 5, 3, 1, 1);

        label_4 = new QLabel(groupBox_2);
        label_4->setObjectName(QString::fromUtf8("label_4"));
        sizePolicy1.setHeightForWidth(label_4->sizePolicy().hasHeightForWidth());
        label_4->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_4, 0, 3, 1, 1);

        label_5 = new QLabel(groupBox_2);
        label_5->setObjectName(QString::fromUtf8("label_5"));
        sizePolicy1.setHeightForWidth(label_5->sizePolicy().hasHeightForWidth());
        label_5->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_5, 1, 3, 1, 1);

        label_7 = new QLabel(groupBox_2);
        label_7->setObjectName(QString::fromUtf8("label_7"));
        sizePolicy1.setHeightForWidth(label_7->sizePolicy().hasHeightForWidth());
        label_7->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_7, 3, 3, 1, 1);

        te_0 = new QTextEdit(groupBox_2);
        te_0->setObjectName(QString::fromUtf8("te_0"));
        sizePolicy.setHeightForWidth(te_0->sizePolicy().hasHeightForWidth());
        te_0->setSizePolicy(sizePolicy);
        te_0->setMinimumSize(QSize(0, 33));
        te_0->setMaximumSize(QSize(16777215, 33));
        te_0->setFont(font2);

        gridLayout_3->addWidget(te_0, 0, 1, 1, 1);

        label_12 = new QLabel(groupBox_2);
        label_12->setObjectName(QString::fromUtf8("label_12"));
        sizePolicy1.setHeightForWidth(label_12->sizePolicy().hasHeightForWidth());
        label_12->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_12, 0, 5, 1, 1);

        label_13 = new QLabel(groupBox_2);
        label_13->setObjectName(QString::fromUtf8("label_13"));
        sizePolicy1.setHeightForWidth(label_13->sizePolicy().hasHeightForWidth());
        label_13->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_13, 1, 5, 1, 1);

        label_14 = new QLabel(groupBox_2);
        label_14->setObjectName(QString::fromUtf8("label_14"));
        sizePolicy1.setHeightForWidth(label_14->sizePolicy().hasHeightForWidth());
        label_14->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_14, 2, 5, 1, 1);

        label_15 = new QLabel(groupBox_2);
        label_15->setObjectName(QString::fromUtf8("label_15"));
        sizePolicy1.setHeightForWidth(label_15->sizePolicy().hasHeightForWidth());
        label_15->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_15, 3, 5, 1, 1);

        label_16 = new QLabel(groupBox_2);
        label_16->setObjectName(QString::fromUtf8("label_16"));
        sizePolicy1.setHeightForWidth(label_16->sizePolicy().hasHeightForWidth());
        label_16->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_16, 4, 5, 1, 1);

        label_17 = new QLabel(groupBox_2);
        label_17->setObjectName(QString::fromUtf8("label_17"));
        sizePolicy1.setHeightForWidth(label_17->sizePolicy().hasHeightForWidth());
        label_17->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_17, 5, 5, 1, 1);

        label_18 = new QLabel(groupBox_2);
        label_18->setObjectName(QString::fromUtf8("label_18"));
        sizePolicy1.setHeightForWidth(label_18->sizePolicy().hasHeightForWidth());
        label_18->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_18, 6, 5, 1, 1);

        label_19 = new QLabel(groupBox_2);
        label_19->setObjectName(QString::fromUtf8("label_19"));
        sizePolicy1.setHeightForWidth(label_19->sizePolicy().hasHeightForWidth());
        label_19->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(label_19, 7, 5, 1, 1);


        verticalLayout->addWidget(groupBox_2);


        retranslateUi(AdcForm);

        cmb_mode->setCurrentIndex(0);
        cmb_drates->setCurrentIndex(0);
        cmb_gain->setCurrentIndex(4);


        QMetaObject::connectSlotsByName(AdcForm);
    } // setupUi

    void retranslateUi(QWidget *AdcForm)
    {
        AdcForm->setWindowTitle(QApplication::translate("AdcForm", "Form", nullptr));
        groupBox->setTitle(QApplication::translate("AdcForm", "Settings", nullptr));
        cmb_mode->setItemText(0, QApplication::translate("AdcForm", "Single-ended input", nullptr));
        cmb_mode->setItemText(1, QApplication::translate("AdcForm", "Differential input", nullptr));

        cmb_drates->setItemText(0, QApplication::translate("AdcForm", "30000", nullptr));
        cmb_drates->setItemText(1, QApplication::translate("AdcForm", "15000", nullptr));
        cmb_drates->setItemText(2, QApplication::translate("AdcForm", "7500", nullptr));
        cmb_drates->setItemText(3, QApplication::translate("AdcForm", "3750", nullptr));
        cmb_drates->setItemText(4, QApplication::translate("AdcForm", "2000", nullptr));
        cmb_drates->setItemText(5, QApplication::translate("AdcForm", "1000", nullptr));
        cmb_drates->setItemText(6, QApplication::translate("AdcForm", "500", nullptr));
        cmb_drates->setItemText(7, QApplication::translate("AdcForm", "100", nullptr));
        cmb_drates->setItemText(8, QApplication::translate("AdcForm", "60", nullptr));
        cmb_drates->setItemText(9, QApplication::translate("AdcForm", "50", nullptr));
        cmb_drates->setItemText(10, QApplication::translate("AdcForm", "30", nullptr));
        cmb_drates->setItemText(11, QApplication::translate("AdcForm", "25", nullptr));
        cmb_drates->setItemText(12, QApplication::translate("AdcForm", "15", nullptr));
        cmb_drates->setItemText(13, QApplication::translate("AdcForm", "10", nullptr));
        cmb_drates->setItemText(14, QApplication::translate("AdcForm", "5", nullptr));
        cmb_drates->setItemText(15, QApplication::translate("AdcForm", "2.5", nullptr));

        pb_setCfg->setText(QApplication::translate("AdcForm", "Set", nullptr));
        pb_start->setText(QApplication::translate("AdcForm", "Start", nullptr));
        label_2->setText(QApplication::translate("AdcForm", "DRate(Hz)", nullptr));
        cmb_gain->setItemText(0, QApplication::translate("AdcForm", "1", nullptr));
        cmb_gain->setItemText(1, QApplication::translate("AdcForm", "2", nullptr));
        cmb_gain->setItemText(2, QApplication::translate("AdcForm", "4", nullptr));
        cmb_gain->setItemText(3, QApplication::translate("AdcForm", "8", nullptr));
        cmb_gain->setItemText(4, QApplication::translate("AdcForm", "16", nullptr));
        cmb_gain->setItemText(5, QApplication::translate("AdcForm", "32", nullptr));
        cmb_gain->setItemText(6, QApplication::translate("AdcForm", "64", nullptr));

        label->setText(QApplication::translate("AdcForm", "Gain", nullptr));
        label_3->setText(QApplication::translate("AdcForm", "Mode", nullptr));
        te_toStress->setHtml(QApplication::translate("AdcForm", "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n"
"<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\n"
"p, li { white-space: pre-wrap; }\n"
"</style></head><body style=\" font-family:'SimSun'; font-size:9pt; font-weight:400; font-style:normal;\">\n"
"<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\">10000</p></body></html>", nullptr));
        label_20->setText(QApplication::translate("AdcForm", "ToStress", nullptr));
        groupBox_2->setTitle(QApplication::translate("AdcForm", "Enable", nullptr));
        cb_use4->setText(QApplication::translate("AdcForm", "Channel4", nullptr));
        label_8->setText(QApplication::translate("AdcForm", "V", nullptr));
        label_10->setText(QApplication::translate("AdcForm", "V", nullptr));
        cb_use2->setText(QApplication::translate("AdcForm", "Channel2", nullptr));
        label_11->setText(QApplication::translate("AdcForm", "V", nullptr));
        cb_use0->setText(QApplication::translate("AdcForm", "Channel0", nullptr));
        cb_use6->setText(QApplication::translate("AdcForm", "Channel6", nullptr));
        cb_use7->setText(QApplication::translate("AdcForm", "Channel7", nullptr));
        label_6->setText(QApplication::translate("AdcForm", "V", nullptr));
        cb_use1->setText(QApplication::translate("AdcForm", "Channel1", nullptr));
        cb_use5->setText(QApplication::translate("AdcForm", "Channel5", nullptr));
        cb_use3->setText(QApplication::translate("AdcForm", "Channel3", nullptr));
        label_9->setText(QApplication::translate("AdcForm", "V", nullptr));
        label_4->setText(QApplication::translate("AdcForm", "V", nullptr));
        label_5->setText(QApplication::translate("AdcForm", "V", nullptr));
        label_7->setText(QApplication::translate("AdcForm", "V", nullptr));
        label_12->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_13->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_14->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_15->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_16->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_17->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_18->setText(QApplication::translate("AdcForm", "MPa", nullptr));
        label_19->setText(QApplication::translate("AdcForm", "MPa", nullptr));
    } // retranslateUi

};

namespace Ui {
    class AdcForm: public Ui_AdcForm {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_ADCFORM_H
