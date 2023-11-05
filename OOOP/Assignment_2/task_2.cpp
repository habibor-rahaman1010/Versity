#include <iostream>
#include <string>
using namespace std;

class Student {
    public:
        string name;
        int id;
        string course;
        string section;
    
    Student(string name, int id, string course, string section) {
        this->name = name;
        this->id = id;
        this->course = course;
        this->section = section;
    }
};

int main() {
    Student myself("Habibor Rahaman", 200694, "Computer Science And Engineering", "A");

    cout << "Name: " << myself.name << endl;
    cout << "ID: " << myself.id << endl;
    cout << "Course: " << myself.course << endl;
    cout << "Section: " << myself.section << endl;

    return 0;
}
