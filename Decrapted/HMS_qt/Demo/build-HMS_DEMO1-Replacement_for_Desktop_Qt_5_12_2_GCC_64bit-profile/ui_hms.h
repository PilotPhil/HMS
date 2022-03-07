/********************************************************************************
** Form generated from reading UI file 'hms.ui'
**
** Created by: Qt User Interface Compiler version 5.12.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_HMS_H
#define UI_HMS_H

#include <QtCore/QVariant>
#include <QtGui/QIcon>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QStackedWidget>
#include <QtWidgets/QTabWidget>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_HMS
{
public:
    QGridLayout *gridLayout;
    QTabWidget *tabWidget;
    QWidget *tab_5;
    QGridLayout *gridLayout_6;
    QPushButton *pushButton_useUdp;
    QPushButton *pushButton_useSerial;
    QSpacerItem *horizontalSpacer_2;
    QWidget *tab;
    QGridLayout *gridLayout_4;
    QPushButton *pushButton_add;
    QPushButton *pushButton_apply;
    QPushButton *pushButton_delete;
    QPushButton *pushButton_cancel;
    QSpacerItem *horizontalSpacer;
    QPushButton *pushButton_refresh;
    QPushButton *pushButton_edit;
    QWidget *tab_2;
    QWidget *tab_3;
    QWidget *tab_4;
    QStackedWidget *stackedWidget;
    QWidget *page_communication;
    QGridLayout *gridLayout_3;
    QWidget *widget_UDP;
    QWidget *widget_serial;
    QSpacerItem *horizontalSpacer_3;
    QWidget *page_sensorCfg;
    QGridLayout *gridLayout_5;
    QWidget *widget_sensorCfg;
    QWidget *page_alrogrium;
    QGridLayout *gridLayout_2;

    void setupUi(QWidget *HMS)
    {
        if (HMS->objectName().isEmpty())
            HMS->setObjectName(QString::fromUtf8("HMS"));
        HMS->resize(1310, 909);
        gridLayout = new QGridLayout(HMS);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        tabWidget = new QTabWidget(HMS);
        tabWidget->setObjectName(QString::fromUtf8("tabWidget"));
        tabWidget->setMaximumSize(QSize(16777215, 150));
        tabWidget->setTabPosition(QTabWidget::North);
        tabWidget->setTabShape(QTabWidget::Rounded);
        tabWidget->setElideMode(Qt::ElideNone);
        tabWidget->setUsesScrollButtons(true);
        tabWidget->setDocumentMode(false);
        tabWidget->setTabsClosable(false);
        tabWidget->setTabBarAutoHide(false);
        tab_5 = new QWidget();
        tab_5->setObjectName(QString::fromUtf8("tab_5"));
        gridLayout_6 = new QGridLayout(tab_5);
        gridLayout_6->setObjectName(QString::fromUtf8("gridLayout_6"));
        pushButton_useUdp = new QPushButton(tab_5);
        pushButton_useUdp->setObjectName(QString::fromUtf8("pushButton_useUdp"));
        QSizePolicy sizePolicy(QSizePolicy::Fixed, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(pushButton_useUdp->sizePolicy().hasHeightForWidth());
        pushButton_useUdp->setSizePolicy(sizePolicy);
        pushButton_useUdp->setMinimumSize(QSize(90, 90));
        pushButton_useUdp->setMaximumSize(QSize(95, 95));
        QFont font;
        font.setFamily(QString::fromUtf8("\351\273\221\344\275\223"));
        font.setPointSize(14);
        pushButton_useUdp->setFont(font);
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/ico/udp_disable.png"), QSize(), QIcon::Normal, QIcon::Off);
        icon.addFile(QString::fromUtf8(":/ico/UDP.png"), QSize(), QIcon::Normal, QIcon::On);
        pushButton_useUdp->setIcon(icon);
        pushButton_useUdp->setIconSize(QSize(32, 32));
        pushButton_useUdp->setCheckable(true);
        pushButton_useUdp->setChecked(true);

        gridLayout_6->addWidget(pushButton_useUdp, 0, 0, 1, 1);

        pushButton_useSerial = new QPushButton(tab_5);
        pushButton_useSerial->setObjectName(QString::fromUtf8("pushButton_useSerial"));
        sizePolicy.setHeightForWidth(pushButton_useSerial->sizePolicy().hasHeightForWidth());
        pushButton_useSerial->setSizePolicy(sizePolicy);
        pushButton_useSerial->setMinimumSize(QSize(90, 90));
        pushButton_useSerial->setMaximumSize(QSize(95, 95));
        pushButton_useSerial->setFont(font);
        QIcon icon1;
        icon1.addFile(QString::fromUtf8(":/ico/serial_disable .png"), QSize(), QIcon::Normal, QIcon::Off);
        icon1.addFile(QString::fromUtf8(":/ico/serial.png"), QSize(), QIcon::Normal, QIcon::On);
        pushButton_useSerial->setIcon(icon1);
        pushButton_useSerial->setIconSize(QSize(32, 32));
        pushButton_useSerial->setCheckable(true);

        gridLayout_6->addWidget(pushButton_useSerial, 0, 1, 1, 1);

        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout_6->addItem(horizontalSpacer_2, 0, 2, 1, 1);

        tabWidget->addTab(tab_5, QString());
        tab = new QWidget();
        tab->setObjectName(QString::fromUtf8("tab"));
        gridLayout_4 = new QGridLayout(tab);
        gridLayout_4->setObjectName(QString::fromUtf8("gridLayout_4"));
        pushButton_add = new QPushButton(tab);
        pushButton_add->setObjectName(QString::fromUtf8("pushButton_add"));
        sizePolicy.setHeightForWidth(pushButton_add->sizePolicy().hasHeightForWidth());
        pushButton_add->setSizePolicy(sizePolicy);
        pushButton_add->setMinimumSize(QSize(90, 90));
        pushButton_add->setMaximumSize(QSize(95, 95));
        pushButton_add->setFont(font);
        QIcon icon2;
        icon2.addFile(QString::fromUtf8(":/ico/more.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_add->setIcon(icon2);
        pushButton_add->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_add, 1, 1, 1, 1);

        pushButton_apply = new QPushButton(tab);
        pushButton_apply->setObjectName(QString::fromUtf8("pushButton_apply"));
        sizePolicy.setHeightForWidth(pushButton_apply->sizePolicy().hasHeightForWidth());
        pushButton_apply->setSizePolicy(sizePolicy);
        pushButton_apply->setMinimumSize(QSize(90, 90));
        pushButton_apply->setMaximumSize(QSize(95, 95));
        pushButton_apply->setFont(font);
        QIcon icon3;
        icon3.addFile(QString::fromUtf8(":/ico/ok.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_apply->setIcon(icon3);
        pushButton_apply->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_apply, 1, 3, 1, 1);

        pushButton_delete = new QPushButton(tab);
        pushButton_delete->setObjectName(QString::fromUtf8("pushButton_delete"));
        sizePolicy.setHeightForWidth(pushButton_delete->sizePolicy().hasHeightForWidth());
        pushButton_delete->setSizePolicy(sizePolicy);
        pushButton_delete->setMinimumSize(QSize(90, 90));
        pushButton_delete->setMaximumSize(QSize(95, 95));
        pushButton_delete->setFont(font);
        QIcon icon4;
        icon4.addFile(QString::fromUtf8(":/ico/less.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_delete->setIcon(icon4);
        pushButton_delete->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_delete, 1, 2, 1, 1);

        pushButton_cancel = new QPushButton(tab);
        pushButton_cancel->setObjectName(QString::fromUtf8("pushButton_cancel"));
        sizePolicy.setHeightForWidth(pushButton_cancel->sizePolicy().hasHeightForWidth());
        pushButton_cancel->setSizePolicy(sizePolicy);
        pushButton_cancel->setMinimumSize(QSize(90, 90));
        pushButton_cancel->setMaximumSize(QSize(95, 95));
        pushButton_cancel->setFont(font);
        QIcon icon5;
        icon5.addFile(QString::fromUtf8(":/ico/cancel.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_cancel->setIcon(icon5);
        pushButton_cancel->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_cancel, 1, 4, 1, 1);

        horizontalSpacer = new QSpacerItem(620, 20, QSizePolicy::MinimumExpanding, QSizePolicy::Minimum);

        gridLayout_4->addItem(horizontalSpacer, 1, 6, 1, 1);

        pushButton_refresh = new QPushButton(tab);
        pushButton_refresh->setObjectName(QString::fromUtf8("pushButton_refresh"));
        sizePolicy.setHeightForWidth(pushButton_refresh->sizePolicy().hasHeightForWidth());
        pushButton_refresh->setSizePolicy(sizePolicy);
        pushButton_refresh->setMinimumSize(QSize(90, 90));
        pushButton_refresh->setMaximumSize(QSize(95, 95));
        pushButton_refresh->setFont(font);
        QIcon icon6;
        icon6.addFile(QString::fromUtf8(":/ico/refresh.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_refresh->setIcon(icon6);
        pushButton_refresh->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_refresh, 1, 0, 1, 1);

        pushButton_edit = new QPushButton(tab);
        pushButton_edit->setObjectName(QString::fromUtf8("pushButton_edit"));
        sizePolicy.setHeightForWidth(pushButton_edit->sizePolicy().hasHeightForWidth());
        pushButton_edit->setSizePolicy(sizePolicy);
        pushButton_edit->setMinimumSize(QSize(90, 90));
        pushButton_edit->setMaximumSize(QSize(95, 95));
        pushButton_edit->setFont(font);
        QIcon icon7;
        icon7.addFile(QString::fromUtf8(":/ico/edit.png"), QSize(), QIcon::Normal, QIcon::Off);
        pushButton_edit->setIcon(icon7);
        pushButton_edit->setIconSize(QSize(32, 32));

        gridLayout_4->addWidget(pushButton_edit, 1, 5, 1, 1);

        tabWidget->addTab(tab, QString());
        tab_2 = new QWidget();
        tab_2->setObjectName(QString::fromUtf8("tab_2"));
        tabWidget->addTab(tab_2, QString());
        tab_3 = new QWidget();
        tab_3->setObjectName(QString::fromUtf8("tab_3"));
        tabWidget->addTab(tab_3, QString());
        tab_4 = new QWidget();
        tab_4->setObjectName(QString::fromUtf8("tab_4"));
        tabWidget->addTab(tab_4, QString());

        gridLayout->addWidget(tabWidget, 0, 0, 1, 1);

        stackedWidget = new QStackedWidget(HMS);
        stackedWidget->setObjectName(QString::fromUtf8("stackedWidget"));
        page_communication = new QWidget();
        page_communication->setObjectName(QString::fromUtf8("page_communication"));
        gridLayout_3 = new QGridLayout(page_communication);
        gridLayout_3->setObjectName(QString::fromUtf8("gridLayout_3"));
        widget_UDP = new QWidget(page_communication);
        widget_UDP->setObjectName(QString::fromUtf8("widget_UDP"));
        QSizePolicy sizePolicy1(QSizePolicy::Fixed, QSizePolicy::Preferred);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(widget_UDP->sizePolicy().hasHeightForWidth());
        widget_UDP->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(widget_UDP, 0, 0, 1, 1);

        widget_serial = new QWidget(page_communication);
        widget_serial->setObjectName(QString::fromUtf8("widget_serial"));
        widget_serial->setEnabled(false);
        sizePolicy1.setHeightForWidth(widget_serial->sizePolicy().hasHeightForWidth());
        widget_serial->setSizePolicy(sizePolicy1);

        gridLayout_3->addWidget(widget_serial, 0, 1, 1, 1);

        horizontalSpacer_3 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout_3->addItem(horizontalSpacer_3, 0, 2, 1, 1);

        stackedWidget->addWidget(page_communication);
        page_sensorCfg = new QWidget();
        page_sensorCfg->setObjectName(QString::fromUtf8("page_sensorCfg"));
        gridLayout_5 = new QGridLayout(page_sensorCfg);
        gridLayout_5->setObjectName(QString::fromUtf8("gridLayout_5"));
        widget_sensorCfg = new QWidget(page_sensorCfg);
        widget_sensorCfg->setObjectName(QString::fromUtf8("widget_sensorCfg"));

        gridLayout_5->addWidget(widget_sensorCfg, 0, 0, 1, 1);

        stackedWidget->addWidget(page_sensorCfg);
        page_alrogrium = new QWidget();
        page_alrogrium->setObjectName(QString::fromUtf8("page_alrogrium"));
        gridLayout_2 = new QGridLayout(page_alrogrium);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        stackedWidget->addWidget(page_alrogrium);

        gridLayout->addWidget(stackedWidget, 1, 0, 1, 1);


        retranslateUi(HMS);
        QObject::connect(tabWidget, SIGNAL(currentChanged(int)), stackedWidget, SLOT(setCurrentIndex(int)));

        tabWidget->setCurrentIndex(0);
        stackedWidget->setCurrentIndex(0);


        QMetaObject::connectSlotsByName(HMS);
    } // setupUi

    void retranslateUi(QWidget *HMS)
    {
        HMS->setWindowTitle(QApplication::translate("HMS", "HMS", nullptr));
        pushButton_useUdp->setText(QApplication::translate("HMS", "UDP", nullptr));
        pushButton_useSerial->setText(QApplication::translate("HMS", "\344\270\262\345\217\243", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_5), QApplication::translate("HMS", "\351\200\232\344\277\241", nullptr));
        pushButton_add->setText(QApplication::translate("HMS", "\345\242\236\345\212\240", nullptr));
        pushButton_apply->setText(QApplication::translate("HMS", "\345\272\224\347\224\250", nullptr));
        pushButton_delete->setText(QApplication::translate("HMS", "\345\210\240\351\231\244", nullptr));
        pushButton_cancel->setText(QApplication::translate("HMS", "\345\217\226\346\266\210", nullptr));
        pushButton_refresh->setText(QApplication::translate("HMS", "\345\210\267\346\226\260", nullptr));
        pushButton_edit->setText(QApplication::translate("HMS", "\347\274\226\350\276\221", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab), QApplication::translate("HMS", "\344\274\240\346\204\237\345\231\250\351\205\215\347\275\256", nullptr));
        tabWidget->setTabWhatsThis(tabWidget->indexOf(tab), QApplication::translate("HMS", "23223333333333", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_2), QApplication::translate("HMS", "\347\256\227\346\263\225", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_3), QApplication::translate("HMS", "\344\277\235\345\255\230", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_4), QApplication::translate("HMS", "\346\230\276\347\244\272", nullptr));
    } // retranslateUi

};

namespace Ui {
    class HMS: public Ui_HMS {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_HMS_H
