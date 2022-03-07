/****************************************************************************
** Meta object code from reading C++ file 'serialcfg.h'
**
** Created by: The Qt Meta Object Compiler version 67 (Qt 5.12.10)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../../HMS_DEMO1/COM/SERIAL/serialcfg.h"
#include <QtCore/qbytearray.h>
#include <QtCore/qmetatype.h>
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'serialcfg.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 67
#error "This file was generated using the moc from 5.12.10. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
QT_WARNING_PUSH
QT_WARNING_DISABLE_DEPRECATED
struct qt_meta_stringdata_SerialCfg_t {
    QByteArrayData data[9];
    char stringdata0[160];
};
#define QT_MOC_LITERAL(idx, ofs, len) \
    Q_STATIC_BYTE_ARRAY_DATA_HEADER_INITIALIZER_WITH_OFFSET(len, \
    qptrdiff(offsetof(qt_meta_stringdata_SerialCfg_t, stringdata0) + ofs \
        - idx * sizeof(QByteArrayData)) \
    )
static const qt_meta_stringdata_SerialCfg_t qt_meta_stringdata_SerialCfg = {
    {
QT_MOC_LITERAL(0, 0, 9), // "SerialCfg"
QT_MOC_LITERAL(1, 10, 14), // "sendSerialData"
QT_MOC_LITERAL(2, 25, 0), // ""
QT_MOC_LITERAL(3, 26, 4), // "data"
QT_MOC_LITERAL(4, 31, 28), // "on_PB_sendSerialData_clicked"
QT_MOC_LITERAL(5, 60, 37), // "on_checkBox_receiveOrNot_stat..."
QT_MOC_LITERAL(6, 98, 4), // "arg1"
QT_MOC_LITERAL(7, 103, 31), // "on_pushButton_clearDisp_clicked"
QT_MOC_LITERAL(8, 135, 24) // "on_PB_openSerial_clicked"

    },
    "SerialCfg\0sendSerialData\0\0data\0"
    "on_PB_sendSerialData_clicked\0"
    "on_checkBox_receiveOrNot_stateChanged\0"
    "arg1\0on_pushButton_clearDisp_clicked\0"
    "on_PB_openSerial_clicked"
};
#undef QT_MOC_LITERAL

static const uint qt_meta_data_SerialCfg[] = {

 // content:
       8,       // revision
       0,       // classname
       0,    0, // classinfo
       5,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       1,       // signalCount

 // signals: name, argc, parameters, tag, flags
       1,    1,   39,    2, 0x06 /* Public */,

 // slots: name, argc, parameters, tag, flags
       4,    0,   42,    2, 0x08 /* Private */,
       5,    1,   43,    2, 0x08 /* Private */,
       7,    0,   46,    2, 0x08 /* Private */,
       8,    0,   47,    2, 0x08 /* Private */,

 // signals: parameters
    QMetaType::Void, QMetaType::QReal,    3,

 // slots: parameters
    QMetaType::Void,
    QMetaType::Void, QMetaType::Int,    6,
    QMetaType::Void,
    QMetaType::Void,

       0        // eod
};

void SerialCfg::qt_static_metacall(QObject *_o, QMetaObject::Call _c, int _id, void **_a)
{
    if (_c == QMetaObject::InvokeMetaMethod) {
        auto *_t = static_cast<SerialCfg *>(_o);
        Q_UNUSED(_t)
        switch (_id) {
        case 0: _t->sendSerialData((*reinterpret_cast< qreal(*)>(_a[1]))); break;
        case 1: _t->on_PB_sendSerialData_clicked(); break;
        case 2: _t->on_checkBox_receiveOrNot_stateChanged((*reinterpret_cast< int(*)>(_a[1]))); break;
        case 3: _t->on_pushButton_clearDisp_clicked(); break;
        case 4: _t->on_PB_openSerial_clicked(); break;
        default: ;
        }
    } else if (_c == QMetaObject::IndexOfMethod) {
        int *result = reinterpret_cast<int *>(_a[0]);
        {
            using _t = void (SerialCfg::*)(qreal );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&SerialCfg::sendSerialData)) {
                *result = 0;
                return;
            }
        }
    }
}

QT_INIT_METAOBJECT const QMetaObject SerialCfg::staticMetaObject = { {
    &QWidget::staticMetaObject,
    qt_meta_stringdata_SerialCfg.data,
    qt_meta_data_SerialCfg,
    qt_static_metacall,
    nullptr,
    nullptr
} };


const QMetaObject *SerialCfg::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->dynamicMetaObject() : &staticMetaObject;
}

void *SerialCfg::qt_metacast(const char *_clname)
{
    if (!_clname) return nullptr;
    if (!strcmp(_clname, qt_meta_stringdata_SerialCfg.stringdata0))
        return static_cast<void*>(this);
    return QWidget::qt_metacast(_clname);
}

int SerialCfg::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QWidget::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        if (_id < 5)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 5;
    } else if (_c == QMetaObject::RegisterMethodArgumentMetaType) {
        if (_id < 5)
            *reinterpret_cast<int*>(_a[0]) = -1;
        _id -= 5;
    }
    return _id;
}

// SIGNAL 0
void SerialCfg::sendSerialData(qreal _t1)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(&_t1)) };
    QMetaObject::activate(this, &staticMetaObject, 0, _a);
}
QT_WARNING_POP
QT_END_MOC_NAMESPACE
