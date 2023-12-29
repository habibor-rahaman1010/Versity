//method overriding in c++ program...
#include <bits/stdc++.h>
using namespace std;

class Base{
    public:
        void print(){
            cout<<"I am form base class \n";
        }
};

class Derived : public Base{
    public:
        void print(){
            cout<<"I am from derived class \n";
        }
};

int main(){
    Derived derive;
    derive.print();
    derive.Base::print();

return 0;
}