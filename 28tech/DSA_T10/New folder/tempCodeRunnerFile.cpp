#include <bits/stdc++.h>
using namespace std;
using ll = long long;
void convert(int n){
    if (n < 2)  cout << n % 2;
    else{
        convert(n / 2);
        cout << n % 2;
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
    convert(10);
}
