//Insert new element in array by index...

#include <stdio.h>
#define size 10

int main(){
    int arr[size], n, position, newelement;

    printf("Enter the value of n: ");
    scanf("%d", &n);

    printf("Enter array element: \n");
    for(int i = 0; i < n; i++){
        printf("Enter %d position of element: ", i + 1);
        scanf("%d", &arr[i]);
    }

return 0;
}