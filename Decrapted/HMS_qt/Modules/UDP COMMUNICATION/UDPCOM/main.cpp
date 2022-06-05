#include "udpcom.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    UDPCOM w;
    w.show();

    return a.exec();
}
