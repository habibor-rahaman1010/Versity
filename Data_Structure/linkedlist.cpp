#include<bits/stdc++.h>
using namespace std;

// Creating a node
class Node {
public:
    int data;
    Node* next;

    // Default constructor
    Node()
    {
        data = 0;
        next = NULL;
    }

    // Parameterised Constructor
    Node(int data)
    {
        this->data = data;
        this->next = NULL;
    }
};
class Linkedlist {
    Node* head;

public:

    Linkedlist() { head = NULL; }

    void insertNode(int);

    void printList();
    void insertBegin(int data);
    void insertEnd(int data);
    void insertAfter(int node, int data);


};

// Function to insert a new node.
void Linkedlist::insertNode(int data)
{
    // Create the new Node.
    Node* newNode = new Node(data);

    // Assign to head
    if (head == NULL) {
        head = newNode;
        return;
    }

    // Traverse till end of list
    Node* temp = head;
    while (temp->next != NULL) {

        // Update temp
        temp = temp->next;
    }

    // Insert at the last.
    temp->next = newNode;
}

// Function to print the
// nodes of the linked list.
void Linkedlist::printList()
{
    Node* temp = head;

    // Check for empty list.
    if (head == NULL) {
        cout << "List empty" << endl;
        return;
    }

    // Traverse the list.
    while (temp != NULL) {
        cout << temp->data << " "<< temp->next<<"  "<<temp <<endl;
        //cout << temp->data << " ";
        temp = temp->next;
    }
    cout<<endl;
}

void Linkedlist:: insertBegin(int data)
{
    Node* newNode = new Node(data);

    newNode->data = data;
    newNode->next = head;
    head = newNode;
}
void Linkedlist:: insertEnd(int data)
{
    Node* newNode = new Node(data);
    Node *temp=head;
    while(temp->next != NULL)
    {
        temp=temp->next;
    }
    temp->next = newNode;
    newNode->data= data;
    newNode->next= NULL;

}
void Linkedlist:: insertAfter(int node, int data)
{
     Node* newNode = new Node(data);
     Node *temp=head;
     while(temp->next != NULL)
     {
         if(temp->data == node)
         {
             newNode->data =data;
             newNode->next = temp->next;
             temp->next = newNode;
             return;
         }
         else
         {
            temp = temp->next;
         }

     }

}

int main()
{
    Linkedlist L;
    L.insertNode(1);
    L.insertNode(2);
    L.insertNode(3);
    L.insertNode(4);
    L.printList();
    L.insertBegin(5);
    L.printList();

    L.insertEnd(6);
    L.printList();

    L.insertAfter(3, 10);
    L.printList();


}

