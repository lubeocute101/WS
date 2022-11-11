#include <bits/stdc++.h>

using namespace std;
using ll = long long;
void phantich(ll n)
{
    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
        { // n = 5, i = 5
            int cnt = 0;
            while (n % i == 0)
            {
                cnt++;  // cnt = 1
                n /= i; // n = 1
            }
            cout << i << "^" << cnt; //
            if (n != 1)
                cout << " * ";
        }
    }
    if (n != 1)
        cout << n << "^1";
}
int main()
{
#ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
#endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);
    ll n;
    cin >> n;
    phantich(n);
}
