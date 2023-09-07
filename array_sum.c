// array sum use funtion in this program

#include <stdio.h>

void array_sum(int ara1[], int ara2[]){
    int sum = 0;
    for(int i = 0; i < 5; i++){
        sum += ara1[i] + ara2[i];
    }
    printf("Tatal sum of tow array: %d", sum);
}

int main(){
    int ara1 [5] = {12, 34, 56, 67, 54};
    int ara2 [5] = {12, 89, 7, 34, 5};

    array_sum(ara1, ara2);

return 0;
}