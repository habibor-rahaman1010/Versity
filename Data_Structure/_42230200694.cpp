#include <iostream>
#include <bits/stdc++.h>
using namespace std;

class Node {
public:
    int data;
    Node* next;
    Node(int value) : data(value), next(NULL) {}
};

class Queue {
private:
    Node* front;
    Node* rear;

public:
    Queue() : front(NULL), rear(NULL) {}
    bool isEmpty() {
        return front == NULL;
    }

    // Function to enqueue 
    void enqueue(int value) {
        Node* newNode = new Node(value);
        if (isEmpty()) {
            front = rear = newNode;
        } 
        else {
            rear->next = newNode;
            rear = newNode;
        }
        cout << "Enqueued: " << value << endl;
    }

    // Function to dequeue
    void dequeue() {
        if (isEmpty()) {
            cout << "Queue is empty. Cannot dequeue." << endl;
            return;
        }
        Node* temp = front;
        front = front->next;

        if (front == NULL) {
            rear = NULL;
        }
        delete temp;
    }

    // Function to display the elements in the queue
    void display() {
        if (isEmpty()) {
            cout << "Queue is empty." << endl;
            return;
        }
        Node* current = front;
        cout << "Queue elements: ";
        while (current != NULL) {
            cout << current->data << " ";
            current = current->next;
        }
        cout << endl;
    }
};

int main() {
    Queue myQueue;
    myQueue.enqueue(10);
    myQueue.enqueue(20);
    myQueue.enqueue(30);
    myQueue.display();
    myQueue.dequeue();
    myQueue.display();

return 0;
}
