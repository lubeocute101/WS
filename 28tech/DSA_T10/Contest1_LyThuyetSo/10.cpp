#include <bits/stdc++.h>
using namespace std;
using ll = long long;
const int MOD = 1e9 + 7;
int main()
{
    #ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
    #endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr); 
    int t; cin >> t;
    ll ans = 1;
    while (t--)
    {
        int a, b; cin >> a >> b;
        ans *= (b + 1);
        ans %= MOD;
    }
    cout << ans;
    
}
