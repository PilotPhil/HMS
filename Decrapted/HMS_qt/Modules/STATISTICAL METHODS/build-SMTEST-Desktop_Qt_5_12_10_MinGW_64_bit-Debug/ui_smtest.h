/********************************************************************************
** Form generated from reading UI file 'smtest.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SMTEST_H
#define UI_SMTEST_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SMTEST
{
public:

    void setupUi(QWidget *SMTEST)
    {
        if (SMTEST->objectName().isEmpty())
            SMTEST->setObjectName(QString::fromUtf8("SMTEST"));
        SMTEST->resize(800, 600);

        retranslateUi(SMTEST);

        QMetaObject::connectSlotsByName(SMTEST);
    } // setupUi

    void retranslateUi(QWidget *SMTEST)
    {
        SMTEST->setWindowTitle(QApplication::translate("SMTEST", "SMTEST", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SMTEST: public Ui_SMTEST {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SMTEST_H
