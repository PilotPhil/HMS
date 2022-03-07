#include "hms.h"

#include <QApplication>
#include <QLoggingCategory>

int main(int argc, char *argv[])
{
    QLoggingCategory::defaultCategory()->setEnabled(QtDebugMsg, true);

    QApplication a(argc, argv);
    HMS w;
    w.show();
    return a.exec();
}
