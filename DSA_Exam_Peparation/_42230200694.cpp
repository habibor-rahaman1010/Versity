//problem- 2

#include <iostream>
using namespace std;
const int MAX_SIZE = 100;

void findCommonElements(int arr1[], int arr2[], int size1, int size2) {
  bool seen[MAX_SIZE] = {false};

  for (int i = 0; i < size1; i++) {
    seen[arr1[i]] = true;
  }

  cout << "Common elements: ";
  for (int i = 0; i < size2; i++) {
    if (seen[arr2[i]]) {
      cout << arr2[i] << " ";
      seen[arr2[i]] = false; 
    }
  }
  cout << endl;
}

int main() {
  int arr1[MAX_SIZE], arr2[MAX_SIZE];
  int size1, size2;

  cout << "Enter size of first array: ";
  cin >> size1;
  cout << "Enter size of second array: ";
  cin >> size2;

  cout << "Enter elements of first array (space separated): ";
  for (int i = 0; i < size1; ++i) {
    cin >> arr1[i];
  }

  cout << "Enter elements of second array (space separated): ";
  for (int i = 0; i < size2; ++i) {
    cin >> arr2[i];
  }

  findCommonElements(arr1, arr2, size1, size2);

  return 0;
}
