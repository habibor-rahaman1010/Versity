//simple friend class example in this code...

#include <bits/stdc++.h>
using namespace std;

class A{
    private: 
        int _balance;
        string _password;
    public:
        A(): _balance(1000), _password("h439r734z"){}

        friend class B;
};

class B{
    public:
        void DisplayofA(const A &a){
            cout<<"Balance: " <<a._balance <<" Passoed: " <<a._password; 
        }
};


int main(){
    A a1;
    B b1;

    b1.DisplayofA(a1);
return 0;
}