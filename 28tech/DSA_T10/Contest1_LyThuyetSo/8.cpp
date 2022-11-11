#include <bits/stdc++.h>
using namespace std;
using ll = long long;
const int maxn = 1e6 + 1;
int t[maxn];
void sang(){
    t[0] = t[1] = 1;
    for (int i = 2; i <= sqrt(maxn); i++){
        if (t[i] == 0){
            for (int j = i * i; j <= maxn; j+=i){
                t[j] = 1;
            }
        }
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
    ll n; cin >> n;
    sang();
    for (ll i = 2; i <= sqrt(n); i++){
        if (t[i] == 0){
            cout << i * i << " ";
        }
    }
}