//implement upcasting in c++ program...

#include <bits/stdc++.h>
using namespace std;

class Shape{
    public:
        virtual void draw(){
            cout<<"Drwaing a shap \n";
        }
};

class Circle : public Shape{
    public:
        void draw() override{
            cout<<"Drwaing a circle \n";
        }
};

class Square : public Shape{
    public:
        void draw() override{
            cout<<"Drwaing a square \n";
        }
};

int main() {
    Shape* shap1 = new Shape();
    shap1->draw();

    Shape* shap2 = new Circle();
    Shape* shap3 = new Square();

    shap2->draw();
    shap3->draw();

return 0;
}