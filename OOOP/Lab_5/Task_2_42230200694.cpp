#include <bits/stdc++.h>
#include <iostream>

using namespace std;

class PlusOperator {
private:
    int num1;
    int num2;
    int num3;
public:
    PlusOperator(int num1, int num2, int num3) : num1(num1), num2(num2), num3(num3){}

    PlusOperator operator+(const PlusOperator &other){
        PlusOperator result (num1 + other.num1, num2 + other.num2, num3 + other.num3);
        return result;
    }
    //Overloading the << operator for output stream
    friend ostream& operator<<(ostream& os, const PlusOperator& obj) {
        os << obj.num1 << ", " << obj.num2 << ", " << obj.num3 <<"\n";
        return os;
    }

    string concatenateStrings(const string& str) {
        return "Northern University Bangladesh" + str;
    }
};

int main() {
    PlusOperator myOperator(10, 20, 30);
    PlusOperator myOperator2(15, 25, 35);

    PlusOperator sum = myOperator + myOperator2;
    cout<<sum;
    string resultString = myOperator.concatenateStrings(" - Dhaka");
    cout << resultString << endl;

    return 0;
}
