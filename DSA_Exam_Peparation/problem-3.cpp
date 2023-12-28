//Find the largest element in an array...

#include <bits/stdc++.h>
using namespace std;

void findLargest(int arr[], int size){
    int max = arr[0];
    for(int i = 0; i < size; i++){
        if(arr[i] > max){
            max = arr[i];
        }
    }
    cout<<"max element: " <<max;
}

int main(){
    int size = 7;
    int arr[size] = {12, 34, 45, 11, 32, 30, 20};

    findLargest(arr, size);

return 0;
}