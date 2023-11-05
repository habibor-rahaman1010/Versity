#include <iostream>
#include <string>
using namespace std;

class Student {
    public:
        string name;
        int id;
        string course;
        string section;

    // Default Constructor look like this
    Student() { 
        name = "";
        id = 0;
        course = "";
        section = "";
    }
};

int main() {
    Student myself;
    myself.name = "Habibor Rahaman";
    myself.id = 200694;
    myself.course = "Computer Science And Engineering";
    myself.section = "A";


    cout << "Name: " << myself.name << endl;
    cout << "ID: " << myself.id << endl;
    cout << "Course: " << myself.course << endl;
    cout << "Section: " << myself.section << endl;

    return 0;
}
