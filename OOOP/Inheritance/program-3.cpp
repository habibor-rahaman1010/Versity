#include <bits/stdc++.h>
using namespace std;

class Body{
    protected:
        string bodyType;
        string color;

    public:
        void BodyMake(){
            cout<<"Body make completed \n";
        }
};

class Engin{
    protected:
        string enginType;
        string oilCapacity;

    public:
        void EnginInstall(){
            cout<<"Engin Installing in Car \n";
        }
};

class Instruments{
    protected:
        string range;
        string Tyer;

    public:
        void setupInstrument(){
            cout<<"Installing instrument in car body \n";
        }
};

class BuildCar : public Body, public Engin, public Instruments{
    public:
        void bildCar(){
            cout<<"Car has been builed...";
        }
};

int main(){
    BuildCar Car;
    Car.BodyMake();
    Car.EnginInstall();
    Car.setupInstrument();
    Car.bildCar();
return 0;
}
