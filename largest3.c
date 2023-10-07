//Find out the largest number in an array...

#include <stdio.h>
int main(){
    int number_arr[10];
    printf("Enter the value of Array: ");
    for (int i = 0; i < 10; i++){
        scanf("%d", &number_arr[i]);
    }
    int largest = number_arr[0];

    for (int i = 0; i < 10; i++){
        if (largest < number_arr[i]){
            largest = number_arr[i];
        }
    }
    printf("Largest number of array: %d", largest);
    return 0;
}