#include <bits/stdc++.h>
#include <iostream>
using namespace std;

class Course{
    public:
        virtual void course_details(){
            cout<<"we are learning multiple courses of CSE this semester." <<"\n";
        }
};

class DataStructure : public Course{
    public:
        void course_details() override{
             cout<<"we are learning multiple chapters of data structure this semester." <<"\n";
        }
};

class C_Plus_Plus : public Course{
    public:
        void course_details() override{
             cout<<"we are learning various applications of C++ this semester." <<"\n";
        }
};

int main(){
    C_Plus_Plus derived1, derived2;
    derived1.course_details();
    derived2.Course::course_details();

    DataStructure child1, child2;
    child1.course_details();
    child2.Course::course_details();
    
return 0;
}