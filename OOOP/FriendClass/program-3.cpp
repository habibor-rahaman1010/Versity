/* Consider a Rectangle class with private member variables length and
width. Create a friend function named calculateArea() that takes a
Rectangle object as a parameter and calculates and returns the area of
the rectangle using the formula area = length * width. Ensure that the
calculateArea() function can access the private member variables of
the Rectangle class. Implement the class and the friend function, and
provide a sample usage in the main() function to demonstrate the
calculation of the area for a given rectangle. */

#include <bits/stdc++.h>
using namespace std;

class Rectangle{
    private:
        int length;
        int width;

    public:
        void setValue(int l, int w){
            this->length = l;
            this->width = w;
        }
        friend double calculateArea(const Rectangle &r);
};

double calculateArea(const Rectangle &r){
    double area = r.length * r.width;
    return area;
}

int main(){
    Rectangle r1;
    r1.setValue(12, 4);
    double area = calculateArea(r1);
    cout<<"Area is: " <<area <<"\n";

return 0;
}
