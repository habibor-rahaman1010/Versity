//hybrid inheritance 

#include <bits/stdc++.h>
using namespace std;

class A{
    protected:
        int a = 10;
        int b = 20;
    public:
     void sum(){
        cout<<"Sum is: " <<a + b <<"\n";
    }
};

class B : public A{
    protected:
        int x = 20;
        int z = 10;
    public:
        void multiplication(){
            cout<<"multiplication is: " << x * z <<"\n";
        }
};

class C{
    protected:
        int n = 10;
        int m = 2;
    public:
        void Devited(){
            cout<<"Divited resutl is: " << n / m <<"\n";
        }
};

class D : public C, public B{
    public:
        void AllResult(){
            sum();
            multiplication();
            Devited();
        }
};

int main(){
    D d;
    d.AllResult();

return 0;
}