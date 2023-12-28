//Write a code to merge two arrays...

#include <iostream>
#include <bits/stdc++.h>
using namespace std;

void margeArray(int arr1[], int arr2[], int size1, int size2){
    int arr[size1 + size2];
    for(int i = 0; i < size1; i++){
        arr[i] = arr1[i];
    }

    for(int i = 0; i < size2; i++){
        arr[size1 + i] = arr2[i];
    }

    for(int i = 0; i < (size1 + size2); i++){
        cout<<arr[i] <<" ";
    }
}

int main(){
    int size1 = 5;
    int size2 = 7;
    int arr1[size1] = {12, 34, 45, 62, 34};
    int arr2[size2] = {23, 12, 17, 374, 21, 99, 100};
    margeArray(arr1, arr2, size1, size2);

return 0;
}
