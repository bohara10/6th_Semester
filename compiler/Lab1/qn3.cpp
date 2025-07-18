#include <iostream>
using namespace std;

enum State { q0, q1, q2, q3 };

bool isAccepted(const string& input) {
    State state = q0;
    for (char ch : input) {
        switch (state) {
            case q0:
                state = (ch == 'a') ? q1 : q0;
                break;
            case q1:
                state = (ch == 'a') ? q1 : q2;
                break;
            case q2:
                state = (ch == 'a') ? q1 : q3;
                break;
            case q3:
                state = (ch == 'a') ? q1 : q0;
                break;
        }
    }
    return state == q3;
}

int main() {
    string input;
    cout << "Enter a string over {a, b}: ";
    cin >> input;

    if (isAccepted(input))
        cout << "String accepted (ends with abb)" << endl;
    else
        cout << "String rejected" << endl;

    return 0;
}
