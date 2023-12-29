//operator overloading in c++ program...

#include <bits/stdc++.h>
using namespace std;

class Complex{
    private:
        double real;
        double imagin;
    
    public:
        Complex(int r, int i) : real(r), imagin(i){}

        Complex operator+(const Complex &other)const{
            return Complex(real + other.real, imagin + other.imagin);
        }
        friend ostream& operator<<(ostream &os, const Complex c);
};

ostream& operator<<(ostream &os, const Complex c){
    os <<c.real <<" + " <<c.imagin <<"i";
    return os;
}

int main(){
    Complex a(3.45, 4.45);
    Complex b(5.45, 6.45);

    Complex result = a + b;
    cout<<result;

return 0;
}