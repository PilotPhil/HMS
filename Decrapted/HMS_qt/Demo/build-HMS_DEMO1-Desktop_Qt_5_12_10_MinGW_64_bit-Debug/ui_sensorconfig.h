/********************************************************************************
** Form generated from reading UI file 'sensorconfig.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SENSORCONFIG_H
#define UI_SENSORCONFIG_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QFrame>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPlainTextEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SENSORCONFIG
{
public:
    QGridLayout *gridLayout_4;
    QHBoxLayout *horizontalLayout_7;
    QVBoxLayout *verticalLayout_2;
    QGroupBox *gb_general;
    QGridLayout *gridLayout;
    QHBoxLayout *horizontalLayout;
    QLabel *lb_name;
    QLineEdit *le_name;
    QCheckBox *checkBox;
    QHBoxLayout *horizontalLayout_2;
    QVBoxLayout *verticalLayout;
    QLabel *lb_description;
    QSpacerItem *verticalSpacer;
    QPlainTextEdit *pte_description;
    QHBoxLayout *horizontalLayout_3;
    QLabel *label;
    QComboBox *comboBox;
    QHBoxLayout *horizontalLayout_6;
    QLabel *lb_name_2;
    QSpinBox *spinBox_id;
    QGroupBox *gb_calibrate;
    QGridLayout *gridLayout_2;
    QHBoxLayout *horizontalLayout_4;
    QLabel *label_2;
    QLineEdit *le_initValue;
    QLabel *lb_unit;
    QHBoxLayout *horizontalLayout_5;
    QLabel *label_3;
    QLineEdit *le_unit;
    QGroupBox *gb_alarm;
    QGroupBox *gb_function;
    QGridLayout *gridLayout_3;
    QCheckBox *cb_rawData;
    QFrame *line;
    QCheckBox *cb_mean;
    QCheckBox *cb_zeroCross;
    QCheckBox *cb_lowPass;
    QCheckBox *cb_damage;
    QCheckBox *cb_std;
    QFrame *line_2;
    QCheckBox *cb_peakVally;
    QCheckBox *cb_highPass;
    QCheckBox *cb_rainflow;
    QFrame *line_3;
    QSpacerItem *verticalSpacer_2;
    QHBoxLayout *horizontalLayout_8;
    QSpacerItem *horizontalSpacer;
    QPushButton *pushButton_yseCreate;
    QPushButton *pushButton_noExit;

    void setupUi(QWidget *SENSORCONFIG)
    {
        if (SENSORCONFIG->objectName().isEmpty())
            SENSORCONFIG->setObjectName(QString::fromUtf8("SENSORCONFIG"));
        SENSORCONFIG->resize(821, 482);
        gridLayout_4 = new QGridLayout(SENSORCONFIG);
        gridLayout_4->setObjectName(QString::fromUtf8("gridLayout_4"));
        horizontalLayout_7 = new QHBoxLayout();
        horizontalLayout_7->setObjectName(QString::fromUtf8("horizontalLayout_7"));
        verticalLayout_2 = new QVBoxLayout();
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        gb_general = new QGroupBox(SENSORCONFIG);
        gb_general->setObjectName(QString::fromUtf8("gb_general"));
        gb_general->setMinimumSize(QSize(250, 300));
        gridLayout = new QGridLayout(gb_general);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        lb_name = new QLabel(gb_general);
        lb_name->setObjectName(QString::fromUtf8("lb_name"));

        horizontalLayout->addWidget(lb_name);

        le_name = new QLineEdit(gb_general);
        le_name->setObjectName(QString::fromUtf8("le_name"));
        le_name->setMinimumSize(QSize(0, 0));

        horizontalLayout->addWidget(le_name);


        gridLayout->addLayout(horizontalLayout, 1, 0, 1, 1);

        checkBox = new QCheckBox(gb_general);
        checkBox->setObjectName(QString::fromUtf8("checkBox"));
        QSizePolicy sizePolicy(QSizePolicy::Minimum, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(checkBox->sizePolicy().hasHeightForWidth());
        checkBox->setSizePolicy(sizePolicy);

        gridLayout->addWidget(checkBox, 4, 0, 1, 1);

        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        lb_description = new QLabel(gb_general);
        lb_description->setObjectName(QString::fromUtf8("lb_description"));

        verticalLayout->addWidget(lb_description);

        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer);


        horizontalLayout_2->addLayout(verticalLayout);

        pte_description = new QPlainTextEdit(gb_general);
        pte_description->setObjectName(QString::fromUtf8("pte_description"));
        pte_description->setMinimumSize(QSize(0, 0));

        horizontalLayout_2->addWidget(pte_description);


        gridLayout->addLayout(horizontalLayout_2, 2, 0, 1, 1);

        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setObjectName(QString::fromUtf8("horizontalLayout_3"));
        label = new QLabel(gb_general);
        label->setObjectName(QString::fromUtf8("label"));

        horizontalLayout_3->addWidget(label);

        comboBox = new QComboBox(gb_general);
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->addItem(QString());
        comboBox->setObjectName(QString::fromUtf8("comboBox"));
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(comboBox->sizePolicy().hasHeightForWidth());
        comboBox->setSizePolicy(sizePolicy1);

        horizontalLayout_3->addWidget(comboBox);


        gridLayout->addLayout(horizontalLayout_3, 3, 0, 1, 1);

        horizontalLayout_6 = new QHBoxLayout();
        horizontalLayout_6->setObjectName(QString::fromUtf8("horizontalLayout_6"));
        lb_name_2 = new QLabel(gb_general);
        lb_name_2->setObjectName(QString::fromUtf8("lb_name_2"));
        QSizePolicy sizePolicy2(QSizePolicy::Preferred, QSizePolicy::Preferred);
        sizePolicy2.setHorizontalStretch(0);
        sizePolicy2.setVerticalStretch(0);
        sizePolicy2.setHeightForWidth(lb_name_2->sizePolicy().hasHeightForWidth());
        lb_name_2->setSizePolicy(sizePolicy2);

        horizontalLayout_6->addWidget(lb_name_2);

        spinBox_id = new QSpinBox(gb_general);
        spinBox_id->setObjectName(QString::fromUtf8("spinBox_id"));
        sizePolicy1.setHeightForWidth(spinBox_id->sizePolicy().hasHeightForWidth());
        spinBox_id->setSizePolicy(sizePolicy1);
        spinBox_id->setMaximum(10000);

        horizontalLayout_6->addWidget(spinBox_id);


        gridLayout->addLayout(horizontalLayout_6, 0, 0, 1, 1);


        verticalLayout_2->addWidget(gb_general);

        gb_calibrate = new QGroupBox(SENSORCONFIG);
        gb_calibrate->setObjectName(QString::fromUtf8("gb_calibrate"));
        gridLayout_2 = new QGridLayout(gb_calibrate);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        horizontalLayout_4 = new QHBoxLayout();
        horizontalLayout_4->setObjectName(QString::fromUtf8("horizontalLayout_4"));
        label_2 = new QLabel(gb_calibrate);
        label_2->setObjectName(QString::fromUtf8("label_2"));

        horizontalLayout_4->addWidget(label_2);

        le_initValue = new QLineEdit(gb_calibrate);
        le_initValue->setObjectName(QString::fromUtf8("le_initValue"));

        horizontalLayout_4->addWidget(le_initValue);

        lb_unit = new QLabel(gb_calibrate);
        lb_unit->setObjectName(QString::fromUtf8("lb_unit"));

        horizontalLayout_4->addWidget(lb_unit);


        gridLayout_2->addLayout(horizontalLayout_4, 0, 0, 1, 1);

        horizontalLayout_5 = new QHBoxLayout();
        horizontalLayout_5->setObjectName(QString::fromUtf8("horizontalLayout_5"));
        label_3 = new QLabel(gb_calibrate);
        label_3->setObjectName(QString::fromUtf8("label_3"));

        horizontalLayout_5->addWidget(label_3);

        le_unit = new QLineEdit(gb_calibrate);
        le_unit->setObjectName(QString::fromUtf8("le_unit"));

        horizontalLayout_5->addWidget(le_unit);


        gridLayout_2->addLayout(horizontalLayout_5, 1, 0, 1, 1);


        verticalLayout_2->addWidget(gb_calibrate);


        horizontalLayout_7->addLayout(verticalLayout_2);

        gb_alarm = new QGroupBox(SENSORCONFIG);
        gb_alarm->setObjectName(QString::fromUtf8("gb_alarm"));
        QSizePolicy sizePolicy3(QSizePolicy::Expanding, QSizePolicy::Preferred);
        sizePolicy3.setHorizontalStretch(0);
        sizePolicy3.setVerticalStretch(0);
        sizePolicy3.setHeightForWidth(gb_alarm->sizePolicy().hasHeightForWidth());
        gb_alarm->setSizePolicy(sizePolicy3);

        horizontalLayout_7->addWidget(gb_alarm);

        gb_function = new QGroupBox(SENSORCONFIG);
        gb_function->setObjectName(QString::fromUtf8("gb_function"));
        sizePolicy3.setHeightForWidth(gb_function->sizePolicy().hasHeightForWidth());
        gb_function->setSizePolicy(sizePolicy3);
        gridLayout_3 = new QGridLayout(gb_function);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        cb_rawData = new QCheckBox(gb_function);
        cb_rawData->setObjectName(QString::fromUtf8("cb_rawData"));

        gridLayout_3->addWidget(cb_rawData, 0, 0, 1, 1);

        line = new QFrame(gb_function);
        line->setObjectName(QString::fromUtf8("line"));
        line->setFrameShape(QFrame::HLine);
        line->setFrameShadow(QFrame::Sunken);

        gridLayout_3->addWidget(line, 1, 0, 1, 1);

        cb_mean = new QCheckBox(gb_function);
        cb_mean->setObjectName(QString::fromUtf8("cb_mean"));

        gridLayout_3->addWidget(cb_mean, 5, 0, 1, 1);

        cb_zeroCross = new QCheckBox(gb_function);
        cb_zeroCross->setObjectName(QString::fromUtf8("cb_zeroCross"));

        gridLayout_3->addWidget(cb_zeroCross, 7, 0, 1, 1);

        cb_lowPass = new QCheckBox(gb_function);
        cb_lowPass->setObjectName(QString::fromUtf8("cb_lowPass"));

        gridLayout_3->addWidget(cb_lowPass, 2, 0, 1, 1);

        cb_damage = new QCheckBox(gb_function);
        cb_damage->setObjectName(QString::fromUtf8("cb_damage"));

        gridLayout_3->addWidget(cb_damage, 12, 0, 1, 1);

        cb_std = new QCheckBox(gb_function);
        cb_std->setObjectName(QString::fromUtf8("cb_std"));

        gridLayout_3->addWidget(cb_std, 6, 0, 1, 1);

        line_2 = new QFrame(gb_function);
        line_2->setObjectName(QString::fromUtf8("line_2"));
        line_2->setFrameShape(QFrame::HLine);
        line_2->setFrameShadow(QFrame::Sunken);

        gridLayout_3->addWidget(line_2, 4, 0, 1, 1);

        cb_peakVally = new QCheckBox(gb_function);
        cb_peakVally->setObjectName(QString::fromUtf8("cb_peakVally"));

        gridLayout_3->addWidget(cb_peakVally, 9, 0, 1, 1);

        cb_highPass = new QCheckBox(gb_function);
        cb_highPass->setObjectName(QString::fromUtf8("cb_highPass"));

        gridLayout_3->addWidget(cb_highPass, 3, 0, 1, 1);

        cb_rainflow = new QCheckBox(gb_function);
        cb_rainflow->setObjectName(QString::fromUtf8("cb_rainflow"));

        gridLayout_3->addWidget(cb_rainflow, 11, 0, 1, 1);

        line_3 = new QFrame(gb_function);
        line_3->setObjectName(QString::fromUtf8("line_3"));
        line_3->setFrameShape(QFrame::HLine);
        line_3->setFrameShadow(QFrame::Sunken);

        gridLayout_3->addWidget(line_3, 8, 0, 1, 1);

        verticalSpacer_2 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        gridLayout_3->addItem(verticalSpacer_2, 13, 0, 1, 1);


        horizontalLayout_7->addWidget(gb_function);


        gridLayout_4->addLayout(horizontalLayout_7, 0, 0, 1, 1);

        horizontalLayout_8 = new QHBoxLayout();
        horizontalLayout_8->setObjectName(QString::fromUtf8("horizontalLayout_8"));
        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_8->addItem(horizontalSpacer);

        pushButton_yseCreate = new QPushButton(SENSORCONFIG);
        pushButton_yseCreate->setObjectName(QString::fromUtf8("pushButton_yseCreate"));

        horizontalLayout_8->addWidget(pushButton_yseCreate);

        pushButton_noExit = new QPushButton(SENSORCONFIG);
        pushButton_noExit->setObjectName(QString::fromUtf8("pushButton_noExit"));

        horizontalLayout_8->addWidget(pushButton_noExit);


        gridLayout_4->addLayout(horizontalLayout_8, 1, 0, 1, 1);


        retranslateUi(SENSORCONFIG);

        QMetaObject::connectSlotsByName(SENSORCONFIG);
    } // setupUi

    void retranslateUi(QWidget *SENSORCONFIG)
    {
        SENSORCONFIG->setWindowTitle(QApplication::translate("SENSORCONFIG", "\344\274\240\346\204\237\345\231\250\351\205\215\347\275\256", nullptr));
        gb_general->setTitle(QApplication::translate("SENSORCONFIG", "\351\200\232\347\224\250", nullptr));
        lb_name->setText(QApplication::translate("SENSORCONFIG", "\345\220\215\347\247\260", nullptr));
        checkBox->setText(QApplication::translate("SENSORCONFIG", "\346\277\200\346\264\273/\347\246\201\347\224\250", nullptr));
        lb_description->setText(QApplication::translate("SENSORCONFIG", "\346\217\217\350\277\260", nullptr));
        label->setText(QApplication::translate("SENSORCONFIG", "\347\261\273\345\236\213", nullptr));
        comboBox->setItemText(0, QApplication::translate("SENSORCONFIG", "NULL", nullptr));
        comboBox->setItemText(1, QApplication::translate("SENSORCONFIG", "LBSG", nullptr));
        comboBox->setItemText(2, QApplication::translate("SENSORCONFIG", "SBSG", nullptr));
        comboBox->setItemText(3, QApplication::translate("SENSORCONFIG", "TEMP", nullptr));
        comboBox->setItemText(4, QApplication::translate("SENSORCONFIG", "ACC", nullptr));

        lb_name_2->setText(QApplication::translate("SENSORCONFIG", "\345\272\217\345\217\267", nullptr));
        gb_calibrate->setTitle(QApplication::translate("SENSORCONFIG", "\346\240\241\346\255\243", nullptr));
        label_2->setText(QApplication::translate("SENSORCONFIG", "\345\210\235\345\247\213\345\200\274", nullptr));
        lb_unit->setText(QApplication::translate("SENSORCONFIG", "uStrain", nullptr));
        label_3->setText(QApplication::translate("SENSORCONFIG", "\345\215\225  \344\275\215", nullptr));
        gb_alarm->setTitle(QApplication::translate("SENSORCONFIG", "\350\255\246\346\212\245", nullptr));
        gb_function->setTitle(QApplication::translate("SENSORCONFIG", "\345\212\237\350\203\275\346\250\241\345\235\227", nullptr));
        cb_rawData->setText(QApplication::translate("SENSORCONFIG", "\345\216\237\345\247\213\346\225\260\346\215\256", nullptr));
        cb_mean->setText(QApplication::translate("SENSORCONFIG", "\345\235\207\345\200\274", nullptr));
        cb_zeroCross->setText(QApplication::translate("SENSORCONFIG", "\345\271\263\345\235\207\350\267\250\351\233\266\347\216\207", nullptr));
        cb_lowPass->setText(QApplication::translate("SENSORCONFIG", "\344\275\216\351\200\232\346\273\244\346\263\242", nullptr));
        cb_damage->setText(QApplication::translate("SENSORCONFIG", "\347\226\262\345\212\263\346\215\237\344\274\244", nullptr));
        cb_std->setText(QApplication::translate("SENSORCONFIG", "\346\240\207\345\207\206\345\267\256", nullptr));
        cb_peakVally->setText(QApplication::translate("SENSORCONFIG", "\345\263\260\350\260\267\346\243\200\346\265\213", nullptr));
        cb_highPass->setText(QApplication::translate("SENSORCONFIG", "\351\253\230\351\200\232\346\273\244\346\263\242", nullptr));
        cb_rainflow->setText(QApplication::translate("SENSORCONFIG", "\351\233\250\346\265\201\350\256\241\346\225\260", nullptr));
        pushButton_yseCreate->setText(QApplication::translate("SENSORCONFIG", "\347\241\256\350\256\244\345\271\266\345\210\233\345\273\272", nullptr));
        pushButton_noExit->setText(QApplication::translate("SENSORCONFIG", "\345\217\226\346\266\210\345\271\266\345\205\263\351\227\255", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SENSORCONFIG: public Ui_SENSORCONFIG {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SENSORCONFIG_H
