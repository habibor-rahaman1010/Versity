//linked list implement...

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
    private:
        Node *head = NULL;
    public:
        LinkedList(){
            head = NULL;
        }

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

        void insertionBefore(int node, int value){
            Node *newNode = new Node(value);
            if(head == NULL){
                head = newNode;
                return;
            }
             // if the target node is the head, update the head
            if (head->data == node) {
                newNode->next = head;
                head = newNode;
                return;
            }

            // Search for the target node
            Node* current = head;
            while (current->next && current->next->data != node) {
                current = current->next;
            }
            if (current->next) {
                newNode->next = current->next;
                current->next = newNode;
                return;
            } 
            else {
                cout << "We can't find the node \n";
            }
        }

        void deleteFromBeginning() {
            if (head == NULL) {
                cout << "The linked list is empty..." <<endl;
                return;
            }
            Node* temp = head;
            head = head->next;
            delete temp;
        }

        void deleteFromEnd() {
        if (head == NULL) {
            cout << "The linked list is empty..." <<endl;
            return;
        }
        
        if (head->next == NULL) {
            delete head;
            head = NULL;
            return;
        }
        
        Node* temp = head;
        Node* prev = NULL;
        while (temp->next != NULL) {
            prev = temp;
            temp = temp->next;
        }
        delete temp;
        prev->next = NULL;
    }

    void deleteAnyNode(int value) {
        if (head == NULL) {
            cout << "The linked list is empty..." <<endl;
            return;
        }

        if (head->data == value) {
            Node* temp = head;
            head = head->next;
            delete temp;
            return;
        }

        Node* temp = head;
        Node* prev = NULL;
        while (temp->next != NULL && temp->data != value) {
            prev = temp;
            temp = temp->next;
        }

        if (temp == NULL) {
            cout << "Node not found..." <<endl;
            return;
        }

        prev->next = temp->next;
        delete temp;
    }

    void printList(){
        Node *start = head;
        while(start != NULL){
            cout <<start->data <<" ";
            start = start->next;
        }
    }
};


int main(){
    LinkedList list;
    list.insertNode(10);
    list.insertNode(20);
    list.insertNode(30);
    list.insertNode(40);
    list.insertNode(50);
    list.insertionBefore(40, 100);
    list.insertionBefore(20, 70);
    list.deleteFromBeginning();
    list.deleteFromEnd();
    list.deleteAnyNode(30);
    list.printList();

    return 0;
}