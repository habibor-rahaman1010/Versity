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
    printf("\n");
    printf("Enter the position of new element: ");
    scanf("%d", &position);
    for(int i = n; i > position; i--){
        arr[i] = arr[i - 1];
    }

    //out of index checking...
    if(position <= n && position >= 0){
        printf("Enter the new element: ");
        scanf("%d", &newelement);
        arr[position] = newelement;
        n++;
    }
    else{
        printf("%d out of index in array... \n", position);
    }

    for(int i = 0; i < n; i++){
        printf("%d \n", arr[i]);
    }

return 0;
}