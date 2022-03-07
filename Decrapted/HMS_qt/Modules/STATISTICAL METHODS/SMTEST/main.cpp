#include "smtest.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    SMTEST w;
    w.show();
    return a.exec();
}
