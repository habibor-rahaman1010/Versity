// find max value in an array use function...

#include <stdio.h>

int find_max(int num[], int size){
    int max = num[0];

    for(int i = 0; i < size; i++){
        if(max < num[i]){
            max = num[i];
        }
    }
    return max;
}

int main() {
    int number[6] = {12, 34, 23, 100, 36, 11};
    int size = sizeof(number) / sizeof(number[0]);  //get array size
    int max_number = find_max(number, size);
    printf("Max value is: %d", max_number);
    return 0;
}