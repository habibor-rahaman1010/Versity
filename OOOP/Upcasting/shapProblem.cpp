//Shap problem use abstruct class

#include <bits/stdc++.h>
using namespace std;

class Shape{
    public:
        virtual void draw() const = 0;
        void displayArea() const{
            cout<<"Area: " <<AreaCalculate() <<"\n";
        }
        virtual double AreaCalculate() const = 0;

        virtual ~Shape(){};
};

class Circle : public Shape{
    private:
        double radious;
    public:
        Circle(double x) : radious(x){};
        void draw() const override {
            cout<< "Drawing Circle \n";
        }
        double AreaCalculate() const override{
            return 3.1416 * radious * radious;
        }
};

class Ractangle : public Shape{
    private:
        double length;
        double width;
    public:
        Ractangle(double l, double w) : length(l), width(w){}

        void draw() const override{
            cout<< "Drawing Ractanguler \n";
        }

        double AreaCalculate() const override {
            return length * width;
        }
};

int main(){

    Circle c(23);
    c.draw();
    c.displayArea();

    Ractangle r(12, 2);
    r.draw();
    r.displayArea();

return 0;
}