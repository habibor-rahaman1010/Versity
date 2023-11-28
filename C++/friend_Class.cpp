//friend class example in this program...

#include <iostream>
#include <bits/stdc++.h>
using namespace std;

class Person{
    private:
        int id;
        string name;
    public:
        Person(int value, string nam) : id(value), name(nam){}
        friend class Student;
};

class Student{
    public:
        void accessPrivetMember(Person &obj){
            cout<<"Id: " <<obj.id <<"\n";
            cout<<"Name: " <<obj.name;
        }
};

int main(){
    Person p(61263, "Habibor Rahaman");
    Student s;
    s.accessPrivetMember(p);

return 0;
}