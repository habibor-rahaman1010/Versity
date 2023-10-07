// Array element delete by index program

#include <stdio.h>

#define size 10

int main() {
    int ara[size];
    int n, position, newnumber;
    printf("Enter amount of element: ");
    scanf("%d", &n);

    printf("\n");
    for(int i = 0; i < n; i++){
        printf("Enter %d element: ", i + 1);
        scanf("%d", &ara[i]);
    }

    printf("Enter the position of delete element: ");
    scanf("%d", &position);

    if(position <= n && position >= 0){
        for(int i = position; i < n; i++){
            ara[i] = ara[i + 1];
        }
        n--;
    }
    else{
        printf("%d out of index in array... \n", position);
    }
    int length = sizeof(ara) / sizeof(ara[0]);
    for(int i = 0; i < n; i++){
        printf("%d \n", ara[i]);
    }
return 0;
}