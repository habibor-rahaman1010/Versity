#include <iostream>
#include <string>

using namespace std;

class Student{
    private:
        int id;
        string name;
        string course;
        string section;

    public:
        void SetId(int id){
            this->id = id;
        }
        int GetId(){
            return this->id;
        }

        void SetName(string name){
            this->name = name;
        }
        string GetName(){
            return this->name;
        }

        void SetCourse(string course){
            this->course = course;
        }

        string GetCourse(){
            return this->course;
        }
       
        void SetSection(string section){
                this->section = section;
        }

        string GetSection(){
            return this->section;
        }

        void ShowStudentDetails(){
            cout<<"Id: " <<this->id <<endl;
            cout<<"Name: " <<this->name <<endl;
            cout<<"Course: ";
            for(int i = 0; i < 5; i++){ 
                cout<<this->course[i] <<" ";
            }
            cout<<endl;
            cout<<"Id: " <<this->section <<endl <<endl;
        }
};

int main(){
    Student Obj;
    Obj.SetId(144369);
    Obj.SetName("Habibor Rahaman");
    Obj.SetCourse("Object Oriented Programming");
    Obj.SetSection("A");

    cout <<"\n---------------"<<"Here Your Studetn Information"<<"------------------------\n";
    cout<< Obj.GetId() <<endl;
    cout<< Obj.GetName() <<endl;
    cout<< Obj.GetCourse() <<endl;
    cout<< Obj.GetSection() <<endl;

return 0;
}