#include <iostream>
using namespace std;

enum State { q0, q1, q2, q_dead };

int main() {
    string input;
    cout << "Enter a string over {a, b}: ";
    cin >> input;

    State state = q0;

    for (char ch : input) {
        if (state == q0)
            state = (ch == 'a') ? q1 : q_dead;
        else if (state == q1)
            state = (ch == 'a') ? q1 : (ch == 'b' ? q2 : q_dead);
        else if (state == q2)
            state = (ch == 'a') ? q1 : (ch == 'b' ? q2 : q_dead);
        else
            state = q_dead;
    }

    cout << ((state == q2) ? "String accepted" : "String rejected") << endl;
    return 0;
}
