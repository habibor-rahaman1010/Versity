//friend funtion in c++ programming...

#include <bits/stdc++.h>
using namespace std;

class Person2;
class Person1{
    private:
        int age;

    public: 
        void setAge(int a){
            this->age = a;
        }
        friend void max(Person1, Person2);
};

class Person2{
    private:
        int age;
    public:
    void setAge(int a){
        this->age = a;
    }
    friend void max(Person1, Person2);
};

void max(Person1 t1, Person2 t2){
    if(t1.age > t2.age){
        cout<<"Age: " <<t1.age <<"\n";
    }
    else{
        cout<<"Age: " <<t2.age <<"\n";
    }
}

int main(){
    Person1 p1;
    Person2 p2;

    p1.setAge(35);
    p2.setAge(20);

    max(p1, p2);

return 0;
}