//Abstruc class implemetation in c++

#include <bits/stdc++.h>
using namespace std;

class Base{
    private:
        int x;

    public:
        virtual void fun() const = 0;
        int getX(){
            return x;
        }
};

class Derived : public Base{
    private:
        int y;
    
    public:
        void fun() const override {
            cout<<"lets go do fun";
        }
};

int main(){
   Derived d;

   d.fun();
return 0;
}
