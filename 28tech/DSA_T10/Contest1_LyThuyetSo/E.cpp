#include <bits/stdc++.h>
using namespace std;
using ll = long long;
const int MAX = 1e6 + 1;
int prime[MAX];
void sieve()
{
    prime[0] = prime[1] = 1;
    for (int i =2; i <= sqrt(MAX); i++){
        if (prime[i] == 0){
            for (int j = i * i; j <= MAX; j += i){
                prime[j] = 1; 
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
    sieve();
    int t; cin >> t;
    while (t--)
    {
        int n; cin >> n;
        for (int a = 2; a <= n/2; a++){
            if (prime[a] == 0){
                int b = n - a;
                if (prime[b] == 0){
                    cout << a << " " << b << endl;
                }
            }
        }
    }
}
