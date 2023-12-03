#include <bits/stdc++.h>
#include <iostream>
using namespace std;

class Calculator{
    public:
        void sum(){
            cout<<"sum is: " <<3 + 8 <<"\n";
        }

        int sum(int x){
            return (x + 10);
        }
        
        int sum(int x, int y){
            return (x + y);
        }

        double sum(double x, double y){
            return (x + y);
        }

        double sum(int x, double y){
            return (x + y);
        }

        float sum(float x, float y, float z){
            return (x + y + z);
        }

        /**
        void sum(float x, float y, float z){
            cout<< (x + y + z);
        }
        Error: cannot overload functions distinguished by return type alone -> befor code run, when i hover mouse on sum funtion
        Error: 'void Calculator::sum(float, float, float)' cannot be overloaded with 'float Calculator::sum(float, float, float)' - After run
        **/
};

int main(){
    Calculator cal;
    cal.sum();
    cout<<"sum is: " <<cal.sum(7) <<"\n";
    cout<<"sum is: " <<cal.sum(20, 10) <<"\n";
    cout<<"sum is: " <<cal.sum(20.50, 12.40) <<"\n";
    cout<<"sum is: " <<cal.sum(5, 12.40) <<"\n";
    cout<<"sum is: " <<cal.sum(5.11, 12.40, 13.2) <<"\n";

return 0;
}