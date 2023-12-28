//Find the occurrence of an integer in an array

#include <iostream>
#include <bits/stdc++.h>

using namespace std;

void isOccurrence(int ara[], int size, int target){
    bool flag = false;
    for(int i = 0; i < size; i++){
        if(ara[i] == target){
            flag = true;
            break;
        }
        else{
            flag = false;
        }
    }
    if(flag){
        cout<<"Find the the target element in this array";  
    }
    else{
        cout<<"Not found the target element in this array";
    }
}

int main(){
    int size = 5;
    int arr[size] = {12, 34, 56, 67, 43};
    int target = 56;

    isOccurrence(arr, size, target);

return 0;
}
