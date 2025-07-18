#include <iostream>
#include <map>
#include <set>
#include <cctype>
#include <vector>
#include <sstream>
using namespace std;

map<char, set<char>> firstSet;
map<char, vector<string>> productions;
set<char> visited;

void computeFirst(char symbol) {
    // Avoid recomputing
    if (visited.count(symbol)) return;
    visited.insert(symbol);

    for (string prod : productions[symbol]) {
        if (prod == "#") {
            firstSet[symbol].insert('#'); // epsilon
        } else {
            for (int i = 0; i < prod.size(); ++i) {
                char ch = prod[i];

                if (!isupper(ch)) {
                    firstSet[symbol].insert(ch); // terminal
                    break;
                } else {
                    computeFirst(ch); // recursively compute FIRST of non-terminal
                    bool epsilonFound = false;
                    for (char x : firstSet[ch]) {
                        if (x == '#') epsilonFound = true;
                        else firstSet[symbol].insert(x);
                    }
                    if (!epsilonFound)
                        break;
                    if (i == prod.size() - 1)
                        firstSet[symbol].insert('#'); // all symbols had epsilon
                }
            }
        }
    }
}

int main() {
    int n;
    cout << "Enter number of productions: ";
    cin >> n;
    cin.ignore();

    cout << "Enter productions (e.g., A->aB|b):\n";
    for (int i = 0; i < n; ++i) {
        string input;
        getline(cin, input);
        char lhs = input[0];
        string rhs = input.substr(3); // after A->

        stringstream ss(rhs);
        string token;
        while (getline(ss, token, '|')) {
            productions[lhs].push_back(token);
        }
    }

    for (auto p : productions) {
        computeFirst(p.first);
    }

    cout << "\nFIRST sets:\n";
    for (auto p : firstSet) {
        cout << "FIRST(" << p.first << ") = { ";
        for (char x : p.second) {
            cout << x << " ";
        }
        cout << "}\n";
    }

    return 0;
}
