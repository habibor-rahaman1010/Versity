// //This Is My Task 1

#include <bits/stdc++.h>
using namespace std;

class Vector {
private:
    int x, y;

public:
    Vector(int x, int y) : x(x), y(y){}
    Vector add(const Vector& other) {
        Vector result(0, 0);
        result.x = this->x + other.x;
        result.y = this->y + other.y;
        return result;
    }
    Vector operator+(const Vector& other) {
        return this->add(other);
    }
    void display() {
        cout << "(" << x << ", " << y << ")";
    }
};

int main() {
    Vector vector1(2, 3);
    Vector vector2(1, 4);
    Vector result = vector1 + vector2;

    cout << "Vector 1: ";
    vector1.display();
    cout << endl;

    cout << "Vector 2: ";
    vector2.display();
    cout << endl;

    cout << "Result: ";
    result.display();
    cout << endl;
return 0;
}
