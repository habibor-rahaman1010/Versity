//implement linked list using c++

#include <bits/stdc++.h>
#include <iostream>

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

class LinkedList{
    Node *head;

    public:
        //insert a node in linked list...
        LinkedList() {head = NULL;}
        void insertNode(int value){
            Node *newNode = new Node(value);
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

        //insert at the begin...
        void insertBegin(int value){
            Node *newNode = new Node();
            Node *temp = head;
            newNode->data = value;
            newNode->next = temp;
            head = newNode;
        }

        //insert at the ending in linekd list...
        void insertEnding(int value){
            Node *newNode = new Node(value);
            Node *temp = head;
            while(temp->next != NULL){
                temp = temp->next;
            }
            temp->next = newNode;
            newNode->data = value;
            newNode->next = NULL;
        }

        //inser after a node in link list...
        void insertAfter(int node, int value ){
            Node *newNode = new Node(value);
            Node *temp = head;
            while(temp->next != NULL){
                if(temp->data == node){
                    newNode->data = value;
                    newNode->next = temp->next;
                    temp->next = newNode;
                    return;
                }
                else{
                    temp = temp->next;
                }
            }
        }

        //print linked list...
        void printList(){
            Node *temp = head;
            if(head == NULL){
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
    LinkedList list;
    list.insertNode(10);
    list.insertNode(20);
    list.insertNode(30);
    list.insertNode(40);
    list.insertBegin(100);
    list.insertEnding(200);
    list.insertAfter(20, 101);

    list.printList();
}