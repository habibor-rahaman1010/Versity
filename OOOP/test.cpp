#include <iostream>
#include <string>
using namespace std;

class Car{
    public:
        string name;
        string model;
        int speed;
        string color;
    private:
        string car_key;
    
    public: void car_key_setter(string key){
        if(key.length() <= 0){
            this->car_key = "dll";
        }
        else{
            this->car_key = key;
        }
    }
    public: string car_key_getter(){
        return this->car_key;
    }

   public: 
        Car(string name, string model, int speed, string color){
            this->name = name;
            this->model = model;
            this->speed = speed;
            this->color = color;
        }
    public: void ShowInfo(){
        cout<<"Name: " << this->name << "\n";
        cout<<"Model: " << this->model << "\n";
        cout<<"Speed: " << this->speed <<"\n";
        cout<<"Color: " << this->color <<"\n";
    }
};

int main(){
    Car toyota = Car("Totyta", "H2G923G6F8T", 260, "Red");
    toyota.ShowInfo();
    toyota.car_key_setter("HJU6F7F8G");
    cout<<"Car Key: " << toyota.car_key_getter();

return 0;
}