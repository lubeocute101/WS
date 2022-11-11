#include <bits/stdc++.h>
using namespace std;
using ll = long long;
int dem(ll n, ll p)
{
    ll ans = 0;
    for (ll i = p; i <= n; i *= p)
    {
        ans += n / i;
    }
    return ans;
}
int main()
{
    #ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
    #endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr); 
    int n, p; cin >> n >> p;
    cout << dem(n, p);
}
