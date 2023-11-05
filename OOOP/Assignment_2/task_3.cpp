#include <iostream>
#include <string>
using namespace std;

class Student {
public:
    string department;
    string section;

    Student(string department, string section) {
        this->department = department;
        this->section = section;
    }

    // Copy Constructor
    Student(const Student &obj) {
        department = obj.department;
        section = obj.section;
    }
};

int main() {
    Student myself("Computer Science And Engineering", "A");
    Student copyOfMyself(myself);

    cout << "Department: " << copyOfMyself.department << endl;
    cout << "Section: " << copyOfMyself.section << endl;

    return 0;
}
