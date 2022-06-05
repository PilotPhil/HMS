/********************************************************************************
** Form generated from reading UI file 'mytable.ui'
**
** Created by: Qt User Interface Compiler version 5.12.10
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MYTABLE_H
#define UI_MYTABLE_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QTableView>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MYTABLE
{
public:
    QGridLayout *gridLayout;
    QTableView *tableView;

    void setupUi(QWidget *MYTABLE)
    {
        if (MYTABLE->objectName().isEmpty())
            MYTABLE->setObjectName(QString::fromUtf8("MYTABLE"));
        MYTABLE->resize(400, 300);
        gridLayout = new QGridLayout(MYTABLE);
        gridLayout->setSpacing(0);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        gridLayout->setContentsMargins(0, 0, 0, 0);
        tableView = new QTableView(MYTABLE);
        tableView->setObjectName(QString::fromUtf8("tableView"));
        tableView->setStyleSheet(QString::fromUtf8(""));

        gridLayout->addWidget(tableView, 0, 0, 1, 1);


        retranslateUi(MYTABLE);

        QMetaObject::connectSlotsByName(MYTABLE);
    } // setupUi

    void retranslateUi(QWidget *MYTABLE)
    {
        MYTABLE->setWindowTitle(QApplication::translate("MYTABLE", "Form", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MYTABLE: public Ui_MYTABLE {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MYTABLE_H
