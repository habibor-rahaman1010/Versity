// for loop drive on string

#include <stdio.h>

int main(void){
    char name[] = "Habibor Rahaman";
    printf("%s \n", name);
    int size = sizeof(name) / sizeof(name[0]);

    for(int i = 0; i < size; i++){
        printf("%s ", name[i]);
    }
    return 0;
}