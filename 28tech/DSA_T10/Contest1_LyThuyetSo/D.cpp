#include <bits/stdc++.h>
using namespace std;
using ll = long long;
const int MAX = 1e7 + 1;
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
bool check(int n){
    while (n != 0)
    {
        int r = n % 10;
        if (r != 2 && r != 3 && r != 5 && r != 7) return false;
        n /= 10;
    }
    return true;
    
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
    int a, b; cin >> a >> b;
    int cnt = 0;
    for (int i = a; i <= b; i++) {
        if (prime[i] == 0 && check(i)){
            cnt++;
        }
    }
    cout << cnt;
}
