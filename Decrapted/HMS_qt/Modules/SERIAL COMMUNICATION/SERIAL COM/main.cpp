#include "SERIALCOM.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    SERIALCOM w;
    w.show();

    return a.exec();
}
