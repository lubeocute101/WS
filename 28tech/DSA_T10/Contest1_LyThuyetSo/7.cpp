#include <bits/stdc++.h>
using namespace std;
using ll = long long;

int main()
{
    #ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
    #endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr); 
    int a, b; cin >> a >> b;
    for (int i = a; i <= b; i++){
        for (int j = i + 1; j <= b; j++){
            if (__gcd(i, j) == 1){
                cout << "(" << i << "," << j << ")\n";
            }
        }
    }
}
