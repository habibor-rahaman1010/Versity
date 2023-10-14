#include <iostream>
#include <string>

int main() {
    std::string input, input2;

    std::cout << "Enter a string with whitespaces: ";
    std::getline(std::cin, input);

    std::cout << "You entered: " << input << std::endl;

    std::cout << "Enter a string with whitespaces: ";
    std::getline(std::cin, input2);

    std::cout << "You entered: " << input2 << std::endl;

    return 0;
}
