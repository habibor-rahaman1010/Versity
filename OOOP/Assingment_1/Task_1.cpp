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
            cout<<endl;
            cout<<"Id: " <<this->section <<endl <<endl;
        }
};

int main(){
    string id;
    string name;
    string courses[5];
    string section;
    cout <<"\n---------------"<<"Enter Your Student Input"<<"------------------------" <<endl;
    cout<<"Enter your id: ";
    getline(cin, id);

    cout<<"Enter your name: ";
    getline(cin, name);

    for(int i = 0; i < 5; i++){
        cout<<"Enter your courses name - " <<i + 1 <<" ";
        getline(cin, courses[i]);
    }
    cout<<"Enter your section name: ";
    getline(cin, section);

    Student habib;
    habib.TakeStudentDetails(stoi(id), name, courses, section);

    cout <<"\n\n---------------"<<"Here Your Studetn Information"<<"------------------------\n";
    habib.ShowStudentDetails();

return 0;
}