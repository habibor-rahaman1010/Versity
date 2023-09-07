// 2 numbar sum useing pointer....

#include <stdio.h>

int main(){
    int* ptr;
    int* ptr2;
    int* ptr3;
    int number = 12, number2 = 12, sum = 0;

    ptr = &number;
    ptr2 = &number2;
    ptr3 = &sum;
    
    *ptr3 = *ptr + *ptr2;
    printf("%d", *ptr3);

    return 0;
}