//This Is My Task 2

#include <bits/stdc++.h>
using namespace std;

class Shape {
public:
    virtual float Area() const {
        return 0;
    }
};

class Rectangle : public Shape {
private:
    float width;
    float height;

public:
    Rectangle(float w, float h) : width(w), height(h) {}
    float Area() const override {
        return width * height;
    }
};

class Triangle : public Shape {
private:
    float base;
    float height;

public:
    Triangle(float b, float h) : base(b), height(h) {}

    float Area() const override {
        return 0.5 * base * height;
    }
};

int main() {
    Rectangle rectangle(5.0, 3.0);
    Triangle triangle(4.0, 6.0);

    cout << "Area of Rectangle: " << rectangle.Area() << endl;
    cout << "Area of Triangle: " << triangle.Area() << endl;

return 0;
}
