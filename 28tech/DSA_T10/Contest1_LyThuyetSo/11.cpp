#include <bits/stdc++.h>
using namespace std;
using ll = long long;
int min_uoc(int n)
{
    if (n == 1) return 1;
    if (n % 2 == 0) return 2;
    else{
        for (int i =2; i <= sqrt(n); i++){
            if (n % i == 0) return i;
        }
        return n;
    }
}
int main()
{
#ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
#endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);
    int n; cin >> n;
    for (int i = 1; i <= n; i++)
    {
        cout << min_uoc(i) << endl;
    }
    return 0;
}