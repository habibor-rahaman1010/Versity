#include <iostream>
#include <bits/stdc++.h>

using namespace std;

class BankAccount;

class Bank {
private:
    vector<BankAccount> accounts;

public:
    void addAccount(const BankAccount& account);
    void displayAccountInfo(int accountNumber);
    void deposit(int accountNumber, double amount);
    void withdraw(int accountNumber, double amount);
};

class BankAccount {
private:
    int accountNumber;
    double balance;
    string ownerName;

public:
    BankAccount(int accNumber, double initialBalance, const string& owner)
        : accountNumber(accNumber), balance(initialBalance), ownerName(owner) {}

    friend class Bank;

    int getAccountNumber() const { return accountNumber; }
    double getBalance() const { return balance; }
    const string& getOwnerName() const { return ownerName; }
};

void Bank::addAccount(const BankAccount& account) {
    accounts.push_back(account);
}

void Bank::displayAccountInfo(int accountNumber) {
    for (const auto& acc : accounts) {
        if (acc.getAccountNumber() == accountNumber) {
            cout << "Account Number: " << acc.getAccountNumber() << "\n";
            cout << "Owner Name: " << acc.getOwnerName() << "\n";
            cout << "Balance: $" << acc.getBalance() << "\n";
            return;
        }
    }
    cout << "Account not found.\n";
}

void Bank::deposit(int accountNumber, double amount) {
    for (auto& acc : accounts) {
        if (acc.getAccountNumber() == accountNumber) {
            acc.balance += amount;
            cout << "Deposit successful. New balance: $" << acc.getBalance() << "\n";
            return;
        }
    }
    cout << "Account not found.\n";
}

void Bank::withdraw(int accountNumber, double amount) {
    for (auto& acc : accounts) {
        if (acc.getAccountNumber() == accountNumber) {
            if (acc.getBalance() >= amount) {
                acc.balance -= amount;
                cout << "Withdrawal successful. New balance: $" << acc.getBalance() << "\n";
            } else {
                cout << "Insufficient funds.\n";
            }
            return;
        }
    }
    cout << "Account not found.\n";
}

int main() {
    Bank bank;

    BankAccount acc1(1001, 1000.0, "John Doe");
    BankAccount acc2(1002, 500.0, "Jane Doe");

    bank.addAccount(acc1);
    bank.addAccount(acc2);

    bank.displayAccountInfo(1001);
    bank.deposit(1002, 200.0);
    bank.withdraw(1001, 300.0);

    return 0;
}
