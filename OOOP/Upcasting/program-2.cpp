//Function hiding 

#include <bits/stdc++.h>
using namespace std;

class Base{
    public:
        void foo(){
            cout<<"It is call from base \n";
        }
};

class Derived : public Base{
    public:
        void foo(){
            cout<<"It is call from derive \n";
        }
};

int main(){
    Derived derived;

    Base *basePtr = &derived;
    derived.foo();
    basePtr->foo();


return 0;
}