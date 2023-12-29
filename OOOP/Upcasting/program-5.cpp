//virtual funtion

#include <bits/stdc++.h>
using namespace std;

class Base{
    public:
        virtual void sum(int x, int y) const = 0;
};

class Derived : public Base{
    public:
        void sum(int n, int m) const override{
            cout<<"Sum is: " <<n + m;
        }
};

int main(){
    Base *b;
    Derived d;
    b = &d;

    b->sum(23, 45);

return 0;
}