#include <iostream>
#include <string>

using namespace std;

class Student{
    public:
        int id;
        string name;
        string course[5];
        string section;

    public:
        void TakeStudentDetails(int id, string name, string course[], string section){
            this->id = id;
            this->name = name;
            for(int i = 0; i < 5; i++){
                this->course[i] = course[i];
            }
            this->section = section;
        }
    public:
        void ShowStudentDetails(){
            cout<<"Id: " <<this->id <<endl;
            cout<<"Name: " <<this->name <<endl;
            cout<<"Course: ";
            for(int i = 0; i < 5; i++){ 
                cout<<this->course[i] <<" ";
            }
            cout<<"Id: " <<this->section <<endl;
        }
};

int main(){
    int id, name, section;
    string courses[5];
    cout<<"Enter your id: ";
    cin>>id;

    cout<<"Enter your name: ";
    cin>>name;

    for(int i = 0; i < 5; i++){
        cout<<"Enter your courses name-%d: " <<i + 1;
        cin>>courses[i];
    }

    Student habib;
    

return 0;
}