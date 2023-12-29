//method overloading in c++ program...

#include <bits/stdc++.h>
using namespace std;

class Calculator{
    public:
        void sum(int a, int b){
            cout<<"Sum is: "<< a + b <<endl;
        }
        void sum(int x, int y, int z){
            cout<<"Sum is: " <<x + y + z <<endl;
        }

};

int main(){

    Calculator cal;
    cal.sum(23, 45);
    cal.sum(34, 45, 56);

return 0;
}