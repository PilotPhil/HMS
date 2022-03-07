/********************************************************************************
** Form generated from reading UI file 'sqlTable.ui'
**
** Created by: Qt User Interface Compiler version 5.12.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SQLTABLE_H
#define UI_SQLTABLE_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QTableView>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SQL_TABLE
{
public:
    QGridLayout *gridLayout;
    QTableView *tableView;

    void setupUi(QWidget *SQL_TABLE)
    {
        if (SQL_TABLE->objectName().isEmpty())
            SQL_TABLE->setObjectName(QString::fromUtf8("SQL_TABLE"));
        SQL_TABLE->resize(558, 416);
        gridLayout = new QGridLayout(SQL_TABLE);
        gridLayout->setSpacing(0);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        gridLayout->setContentsMargins(0, 0, 0, 0);
        tableView = new QTableView(SQL_TABLE);
        tableView->setObjectName(QString::fromUtf8("tableView"));
        tableView->setStyleSheet(QString::fromUtf8("QHeaderView::section \n"
"{\n"
"	background-color: #1296db;\n"
"}\n"
"alternate-background-color: #e1e1e1;\n"
"background-color: white;"));
        tableView->setSortingEnabled(true);

        gridLayout->addWidget(tableView, 0, 0, 1, 1);


        retranslateUi(SQL_TABLE);

        QMetaObject::connectSlotsByName(SQL_TABLE);
    } // setupUi

    void retranslateUi(QWidget *SQL_TABLE)
    {
        SQL_TABLE->setWindowTitle(QApplication::translate("SQL_TABLE", "Form", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SQL_TABLE: public Ui_SQL_TABLE {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SQLTABLE_H
