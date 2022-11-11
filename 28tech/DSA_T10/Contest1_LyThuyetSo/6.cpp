#include <bits/stdc++.h>
using namespace std;
using ll = long long;

bool isPrime(int n)
{
    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return n > 1;
}
bool check(int n)
{
    int sum = 0;
    while (n)
    {
        int r = n % 10;
        sum += r;
        if (r != 2 && r != 5 && r != 7 && r != 3)
            return false;
        n /= 10;
    }
    return isPrime(sum);
}
int main()
{
#ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
#endif
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);
    int cnt = 0;
    int a, b;
    cin >> a >> b;
    for (int i = a; i <= b; i++)
    {
        if (check(i) && isPrime(i))
        {
            cnt++;
        }
    }
    cout << cnt;
}
