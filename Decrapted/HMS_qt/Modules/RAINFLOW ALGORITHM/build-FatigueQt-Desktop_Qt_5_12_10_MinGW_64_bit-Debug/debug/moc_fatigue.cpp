/****************************************************************************
** Meta object code from reading C++ file 'fatigue.h'
**
** Created by: The Qt Meta Object Compiler version 67 (Qt 5.12.10)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../../FatigueQt/fatigue.h"
#include <QtCore/qbytearray.h>
#include <QtCore/qmetatype.h>
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'fatigue.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 67
#error "This file was generated using the moc from 5.12.10. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
QT_WARNING_PUSH
QT_WARNING_DISABLE_DEPRECATED
struct qt_meta_stringdata_FATIGUE_t {
    QByteArrayData data[29];
    char stringdata0[333];
};
#define QT_MOC_LITERAL(idx, ofs, len) \
    Q_STATIC_BYTE_ARRAY_DATA_HEADER_INITIALIZER_WITH_OFFSET(len, \
    qptrdiff(offsetof(qt_meta_stringdata_FATIGUE_t, stringdata0) + ofs \
        - idx * sizeof(QByteArrayData)) \
    )
static const qt_meta_stringdata_FATIGUE_t qt_meta_stringdata_FATIGUE = {
    {
QT_MOC_LITERAL(0, 0, 7), // "FATIGUE"
QT_MOC_LITERAL(1, 8, 13), // "sendAll2Table"
QT_MOC_LITERAL(2, 22, 0), // ""
QT_MOC_LITERAL(3, 23, 2), // "DF"
QT_MOC_LITERAL(4, 26, 5), // "count"
QT_MOC_LITERAL(5, 32, 5), // "range"
QT_MOC_LITERAL(6, 38, 4), // "mean"
QT_MOC_LITERAL(7, 43, 5), // "start"
QT_MOC_LITERAL(8, 49, 3), // "end"
QT_MOC_LITERAL(9, 53, 15), // "sendCsvFileName"
QT_MOC_LITERAL(10, 69, 8), // "fileName"
QT_MOC_LITERAL(11, 78, 11), // "sendKValues"
QT_MOC_LITERAL(12, 90, 1), // "K"
QT_MOC_LITERAL(13, 92, 15), // "sendUltraStress"
QT_MOC_LITERAL(14, 108, 1), // "U"
QT_MOC_LITERAL(15, 110, 21), // "on_CB_rawData_clicked"
QT_MOC_LITERAL(16, 132, 7), // "checked"
QT_MOC_LITERAL(17, 140, 23), // "on_CB_peakVally_clicked"
QT_MOC_LITERAL(18, 164, 23), // "on_PB_inputData_clicked"
QT_MOC_LITERAL(19, 188, 12), // "receiveRData"
QT_MOC_LITERAL(20, 201, 6), // "RData*"
QT_MOC_LITERAL(21, 208, 2), // "rd"
QT_MOC_LITERAL(22, 211, 14), // "receiveCsvData"
QT_MOC_LITERAL(23, 226, 9), // "peakVally"
QT_MOC_LITERAL(24, 236, 31), // "on_comboBox_currentIndexChanged"
QT_MOC_LITERAL(25, 268, 5), // "index"
QT_MOC_LITERAL(26, 274, 29), // "on_doubleSpinBox_valueChanged"
QT_MOC_LITERAL(27, 304, 4), // "arg1"
QT_MOC_LITERAL(28, 309, 23) // "on_PB_reCompute_clicked"

    },
    "FATIGUE\0sendAll2Table\0\0DF\0count\0range\0"
    "mean\0start\0end\0sendCsvFileName\0fileName\0"
    "sendKValues\0K\0sendUltraStress\0U\0"
    "on_CB_rawData_clicked\0checked\0"
    "on_CB_peakVally_clicked\0on_PB_inputData_clicked\0"
    "receiveRData\0RData*\0rd\0receiveCsvData\0"
    "peakVally\0on_comboBox_currentIndexChanged\0"
    "index\0on_doubleSpinBox_valueChanged\0"
    "arg1\0on_PB_reCompute_clicked"
};
#undef QT_MOC_LITERAL

static const uint qt_meta_data_FATIGUE[] = {

 // content:
       8,       // revision
       0,       // classname
       0,    0, // classinfo
      12,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       4,       // signalCount

 // signals: name, argc, parameters, tag, flags
       1,    5,   74,    2, 0x06 /* Public */,
       9,    1,   85,    2, 0x06 /* Public */,
      11,    1,   88,    2, 0x06 /* Public */,
      13,    1,   91,    2, 0x06 /* Public */,

 // slots: name, argc, parameters, tag, flags
      15,    1,   94,    2, 0x08 /* Private */,
      17,    1,   97,    2, 0x08 /* Private */,
      18,    0,  100,    2, 0x08 /* Private */,
      19,    1,  101,    2, 0x08 /* Private */,
      22,    1,  104,    2, 0x08 /* Private */,
      24,    1,  107,    2, 0x08 /* Private */,
      26,    1,  110,    2, 0x08 /* Private */,
      28,    0,  113,    2, 0x08 /* Private */,

 // signals: parameters
    QMetaType::Void, 0x80000000 | 3, 0x80000000 | 3, 0x80000000 | 3, 0x80000000 | 3, 0x80000000 | 3,    4,    5,    6,    7,    8,
    QMetaType::Void, QMetaType::QString,   10,
    QMetaType::Void, QMetaType::Double,   12,
    QMetaType::Void, QMetaType::Double,   14,

 // slots: parameters
    QMetaType::Void, QMetaType::Bool,   16,
    QMetaType::Void, QMetaType::Bool,   16,
    QMetaType::Void,
    QMetaType::Void, 0x80000000 | 20,   21,
    QMetaType::Void, 0x80000000 | 3,   23,
    QMetaType::Void, QMetaType::Int,   25,
    QMetaType::Void, QMetaType::Double,   27,
    QMetaType::Void,

       0        // eod
};

void FATIGUE::qt_static_metacall(QObject *_o, QMetaObject::Call _c, int _id, void **_a)
{
    if (_c == QMetaObject::InvokeMetaMethod) {
        auto *_t = static_cast<FATIGUE *>(_o);
        Q_UNUSED(_t)
        switch (_id) {
        case 0: _t->sendAll2Table((*reinterpret_cast< DF(*)>(_a[1])),(*reinterpret_cast< DF(*)>(_a[2])),(*reinterpret_cast< DF(*)>(_a[3])),(*reinterpret_cast< DF(*)>(_a[4])),(*reinterpret_cast< DF(*)>(_a[5]))); break;
        case 1: _t->sendCsvFileName((*reinterpret_cast< QString(*)>(_a[1]))); break;
        case 2: _t->sendKValues((*reinterpret_cast< double(*)>(_a[1]))); break;
        case 3: _t->sendUltraStress((*reinterpret_cast< double(*)>(_a[1]))); break;
        case 4: _t->on_CB_rawData_clicked((*reinterpret_cast< bool(*)>(_a[1]))); break;
        case 5: _t->on_CB_peakVally_clicked((*reinterpret_cast< bool(*)>(_a[1]))); break;
        case 6: _t->on_PB_inputData_clicked(); break;
        case 7: _t->receiveRData((*reinterpret_cast< RData*(*)>(_a[1]))); break;
        case 8: _t->receiveCsvData((*reinterpret_cast< DF(*)>(_a[1]))); break;
        case 9: _t->on_comboBox_currentIndexChanged((*reinterpret_cast< int(*)>(_a[1]))); break;
        case 10: _t->on_doubleSpinBox_valueChanged((*reinterpret_cast< double(*)>(_a[1]))); break;
        case 11: _t->on_PB_reCompute_clicked(); break;
        default: ;
        }
    } else if (_c == QMetaObject::RegisterMethodArgumentMetaType) {
        switch (_id) {
        default: *reinterpret_cast<int*>(_a[0]) = -1; break;
        case 7:
            switch (*reinterpret_cast<int*>(_a[1])) {
            default: *reinterpret_cast<int*>(_a[0]) = -1; break;
            case 0:
                *reinterpret_cast<int*>(_a[0]) = qRegisterMetaType< RData* >(); break;
            }
            break;
        }
    } else if (_c == QMetaObject::IndexOfMethod) {
        int *result = reinterpret_cast<int *>(_a[0]);
        {
            using _t = void (FATIGUE::*)(DF , DF , DF , DF , DF );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&FATIGUE::sendAll2Table)) {
                *result = 0;
                return;
            }
        }
        {
            using _t = void (FATIGUE::*)(QString );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&FATIGUE::sendCsvFileName)) {
                *result = 1;
                return;
            }
        }
        {
            using _t = void (FATIGUE::*)(double );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&FATIGUE::sendKValues)) {
                *result = 2;
                return;
            }
        }
        {
            using _t = void (FATIGUE::*)(double );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&FATIGUE::sendUltraStress)) {
                *result = 3;
                return;
            }
        }
    }
}

QT_INIT_METAOBJECT const QMetaObject FATIGUE::staticMetaObject = { {
    &QWidget::staticMetaObject,
    qt_meta_stringdata_FATIGUE.data,
    qt_meta_data_FATIGUE,
    qt_static_metacall,
    nullptr,
    nullptr
} };


const QMetaObject *FATIGUE::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->dynamicMetaObject() : &staticMetaObject;
}

void *FATIGUE::qt_metacast(const char *_clname)
{
    if (!_clname) return nullptr;
    if (!strcmp(_clname, qt_meta_stringdata_FATIGUE.stringdata0))
        return static_cast<void*>(this);
    return QWidget::qt_metacast(_clname);
}

int FATIGUE::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QWidget::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        if (_id < 12)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 12;
    } else if (_c == QMetaObject::RegisterMethodArgumentMetaType) {
        if (_id < 12)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 12;
    }
    return _id;
}

// SIGNAL 0
void FATIGUE::sendAll2Table(DF _t1, DF _t2, DF _t3, DF _t4, DF _t5)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(&_t1)), const_cast<void*>(reinterpret_cast<const void*>(&_t2)), const_cast<void*>(reinterpret_cast<const void*>(&_t3)), const_cast<void*>(reinterpret_cast<const void*>(&_t4)), const_cast<void*>(reinterpret_cast<const void*>(&_t5)) };
    QMetaObject::activate(this, &staticMetaObject, 0, _a);
}

// SIGNAL 1
void FATIGUE::sendCsvFileName(QString _t1)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(&_t1)) };
    QMetaObject::activate(this, &staticMetaObject, 1, _a);
}

// SIGNAL 2
void FATIGUE::sendKValues(double _t1)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(&_t1)) };
    QMetaObject::activate(this, &staticMetaObject, 2, _a);
}

// SIGNAL 3
void FATIGUE::sendUltraStress(double _t1)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(&_t1)) };
    QMetaObject::activate(this, &staticMetaObject, 3, _a);
}
QT_WARNING_POP
QT_END_MOC_NAMESPACE
