#include<stdio.h>
int main(){
    int a[8] ={5, 2, 3, 1, 4, 5, 2}, i;
    for(i = 0; i < 8; i++){
        if(a[i] % 2 == 1){
            printf("%d ", i);
        }
    }
return 0;
}