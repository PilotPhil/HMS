#include "visualdevicedriver.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    VisualDeviceDriver w;
    w.show();
    return a.exec();
}
