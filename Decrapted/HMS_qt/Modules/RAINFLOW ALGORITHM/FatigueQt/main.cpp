#include "fatigue.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    FATIGUE w;
    w.show();

    return a.exec();
}
