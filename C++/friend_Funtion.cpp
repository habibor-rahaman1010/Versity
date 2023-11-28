//friend funtion example in this program...

#include <iostream>
#include <bits/stdc++.h>
using namespace std;

class Distance{
    private:
        int meter;
        friend int addMeter(Distance);
    public:
        Distance(int value) : meter(value){}
};

int addMeter(Distance d){
   return d.meter + 5;
}

int main(){
    Distance distance(10);
    int result = addMeter(distance);
    cout<<"Distance of meter: " <<result;
}