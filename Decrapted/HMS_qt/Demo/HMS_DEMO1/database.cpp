#include "database.h"

DATABASE * DATABASE::_dbInstance=nullptr;

DATABASE::DATABASE(QObject *parent) : QObject(parent)
{

}

DATABASE::~DATABASE()
{
    db.close();//析构时断开连接
}

DATABASE *DATABASE::dbInstance(QObject *parent)
{
    if(_dbInstance==nullptr)
    {
        _dbInstance=new DATABASE(parent);
    }
    return _dbInstance;
}

void DATABASE::dbInit()
{
    if(QSqlDatabase::contains("qt_sql_default_connection"))
    {
        db=QSqlDatabase::database("qt_sql_default_connection");
        qDebug()<<"已有数据库连接："<<"qt_sql_default_connection";
    }
    else
    {
        db=QSqlDatabase::addDatabase("QMYSQL");
        db.setHostName("127.0.0.1");//数据库服务器IP
        db.setUserName("root");//数据库用户名
        db.setPassword("1126");//数据库密码
        db.setDatabaseName(DB_NAME);//使用哪个数据库
    }

    qDebug()<<"df:"<<db.lastError();

    //连接数据库
    if(db.open()==false)
    {
        qDebug()<<"failed to connect database"<<db.lastError();
        QMessageBox::warning(nullptr,"数据库打开错误",db.lastError().text(),QMessageBox::Ok,QMessageBox::NoButton);
        return;
    }
}


void DATABASE::insert2SensorCfg(int id,QString type,QString name,QString location)
{
    QSqlQuery query;//
    query.prepare("INSERT INTO SENSOR VALUES (:id,:type,:name,:location)");//预处理
    query.bindValue(":id",id);
    query.bindValue(":type",type);
    query.bindValue(":name",name);
    query.bindValue(":location",location);
//    query.execBatch();

    if(!query.exec())
    {
        qDebug() << "Error:" << query.lastError();
    }
    else
    {
        qDebug() << "insert ok!";
    }
}

void DATABASE::orderByType(const QString &tableName,const QString &order)
{
    QSqlQuery query;
    query.exec(QString("select * from %1 order by %2 ASC;").arg(tableName).arg(order));
}

void DATABASE::selectAllFrom(const QString &tableName)
{
    QSqlQuery query;
    query.exec(QString("select * from %1;").arg(tableName));
}
