//multi level inheritance in c++ progrm...

#include <bits/stdc++.h>
using namespace std;

class Animal{
    public:
        void Calling(){
            cout<<"Ghew Ghew \n";
        }
};

class Dog : public Animal{
    public:
        void Eating(){
            cout<<"Dog eating \n";
        }
};

class BabyDog : public Dog{
    public:
        void BabyDogCalling(){
            cout<<"mew mew";
        }
};

int main(){

    BabyDog dog;
    dog.Calling();
    dog.Eating();
    dog.BabyDogCalling();

return 0;
}