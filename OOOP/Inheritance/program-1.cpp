//single inheritane in c++ program...

#include <bits/stdc++.h>
using namespace std;

class Animal{
    public:
        string name;
        string color;
        void Eatting(){
            cout<<"Animals Eting... \n";
        }
};

class Dog : public Animal{
    public:
        void Call(){
            cout<<"Ghew Ghew \n";
        }
};

int main(){

    Dog dog;
    dog.Call();
    dog.Eatting();

    return 0;
}