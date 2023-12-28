//shap problem in Hierarchical Inheritance

#include <bits/stdc++.h>
using namespace std;

class Shape{
    protected:
        int a;
        int b;
    public :
        void getData(int a, int b){
            this->a = a;
            this->b = b;
        }
};

class Rectangle : public Shape{
    public:
        void rectArea(){
            cout<<"Reactangle area: "<<a * b;
        }
};

class Triangle : public Shape{
    public:
        void triangle(){
            cout<<"Triangle area: " << 0.5 * a * b;
        }
};

int main(){
    Rectangle r;
    r.getData(12, 2);
    r.rectArea();
    
    Triangle t;
    t.getData(5, 2);
    t.triangle();


return 0;
}