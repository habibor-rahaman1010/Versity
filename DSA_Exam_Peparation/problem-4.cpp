//Find Prime numbers in an array...

#include <bits/stdc++.h>
using namespace std;

bool isPrime(int num){
    if(num <= 1){
        return false;
    }
    for(int i = 2; i <= sqrt(num); i++){
        if(num % i == 0){
            return false;
        }
    }
    return true;
}

void findPrime(int arr[], int size){
    for(int i = 0; i < size; i++){
        if(isPrime(arr[i])){
            cout<<arr[i] <<" ";
        }
    }
}

int main(){
    int size = 7;
    int arr[size] = {12, 7, 11, 50, 70, 2, 93};

    findPrime(arr, size);

return 0;
}
