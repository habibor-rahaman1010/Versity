//virtural function in c++....

#include <bits/stdc++.h>
using namespace std;

class Base{
    public:
        virtual void print(){
            cout<<"print from base class \n";
        }

        void show(){
            cout<<"shoing from base class \n";
        }
};

class Derived : public Base{
    public:
        void print(){
            cout<<"print from derived class \n";
        }

        void show(){
            cout<<"Show from derived class \n";
        }
};

int main(){
    Derived d;
    d.print();

    Base *b = &d;
    b->print();
    b->show();
return 0;
}
