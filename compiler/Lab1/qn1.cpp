#include <iostream>
using namespace std;

int main() {
    string input;
    cout << "Enter the string: ";
    cin >> input;

    int state = 0;
    for (char c : input) {
        if      (state == 0 && c == '1') state = 1;
        else if (state == 1 && c == '0') state = 2;
        else if (state == 2 && c == '1') state = 3;
        else if (state == 3 && c == '0') state = 4;
        else state = 5; // dead state
    }

    if (state == 4 && input.length() == 4)
        cout << " String Is Accepted\n";
    else
        cout << "String Is Rejected\n";

    return 0;
}

