#ifndef SMTEST_H
#define SMTEST_H

#include <QWidget>
#include <sm.h>
#include <vector>

QT_BEGIN_NAMESPACE
namespace Ui { class SMTEST; }
QT_END_NAMESPACE

class SMTEST : public QWidget
{
    Q_OBJECT

public:
    SMTEST(QWidget *parent = nullptr);
    ~SMTEST();

private:
    Ui::SMTEST *ui;

    SM * sm;
};
#endif // SMTEST_H
