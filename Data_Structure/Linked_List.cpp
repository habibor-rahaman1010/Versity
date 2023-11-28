#include <iostream>
#include <bits/stdc++.h>
using namespace std;

class Node{
    public:
        int data;
        Node *next;

        Node(){
            data = 0;
            next = NULL;
        }

        Node(int value){
            data = value;
            next = NULL;
        }
};
class LinkeList{
    private:
        Node *head;
        Node * CreateNode(int value){
            return new Node(value);
        }
    public:
        LinkeList(){head = NULL;}

        //Insert node in a list...
        void InsertNode(int value){
            Node *newNode = CreateNode(value);
            
            if(head == NULL){
                head = newNode;
                return;
            }
            Node *temp = head;
            while(temp->next != NULL){
                temp = temp->next;
            }
            
            temp->next = newNode;
        }
        //before Insert at head in link list...
        void InsertBefor(int value){
            Node *newNode = CreateNode(value);
            Node *temp = head;
            if(head == NULL){
                head = newNode;
                return;
            }
            newNode->next = temp;
            head = newNode;
        }

        //Insert after at end of list in linked list...
        void InsertAfter(int value){
            Node *newnode = CreateNode(value);
            Node *temp = head;
            if(head == NULL){
                head = newnode;
                return;
            }
            while(temp->next != NULL){
                temp = temp->next;
            }
            temp->next = newnode;
        }

        //Inser after a node in linked list...
        void InsertAfterAnyNode(int node, int value){
            Node *newNode = CreateNode(value);
            Node *temp = head;
            if(head == NULL){
                head = newNode;
                return;
            }
            while(temp->next != NULL){
                if(temp->data == node){
                    newNode->next = temp->next;
                    temp->next = newNode;
                    return;
                }
                else{
                    temp = temp->next;
                }
            }
        }

        //Insert before any node in link list...
        void InsertBeforAnyNode(int node, int value){
            Node *newNode = CreateNode(value);
            Node *current = head;

            if(head == NULL){
                head = newNode;
            }
            if(head->data == node){
                newNode->next = head;
                head = newNode;
                return;
            }
            while(current->next != NULL && current->next->data != node){
                current = current->next;
            }
            cout<<current->data <<"\n";
            if(current->next){
                newNode->next = current->next;
                current->next = newNode;
            }
        }

        void PrintList(){
            Node *temp = head;
            if(temp == NULL){
                cout<<"List is empty...";
                return;
            }
            while(temp != NULL){
                cout<<temp->data <<" ";
                temp = temp->next;
            }
        }
};


int main(){
    LinkeList list;
    list.InsertNode(10);
    list.InsertNode(20);
    list.InsertNode(30);
    list.InsertNode(40);
    list.InsertBefor(100);
    list.InsertAfter(200);
    list.InsertAfterAnyNode(20, 300);
    list.InsertBeforAnyNode(40, 600);
    list.PrintList();


return 0;
}