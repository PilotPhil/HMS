#include "docsv.h"

DOCSV::DOCSV(QObject *parent) : QObject(parent)
{
    data=new QVector<double>;
}

void DOCSV::receiveFileNameRead(QString fileName)
{
    data->clear();//先清除成员元素

    QDir dir = QDir::current();
    QFile file(dir.filePath(fileName));

    if(!file.open(QIODevice::ReadOnly))
         qDebug()<<"OPEN FILE FAILED";
    else
        qDebug()<<"OPEN FILE SUCESSED";

    QTextStream * out = new QTextStream(&file);//文本流
    QStringList tempOption = out->readAll().split("\n");//每行以\n区分

    qDebug()<<tempOption.size();

    for(int i = 0 ; i < tempOption.count() ; i++)
    {
         qDebug()<<tempOption.at(i);
         data->append(tempOption.at(i).toDouble());//逐个拷贝内容
    }
    file.close();//操作完成后记得关闭文件

    sendCsvData(*data);//发送读取到的数据

}
