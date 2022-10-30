#include <iostream>
#include <cmath>
using namespace std;

bool isPrime(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= sqrt(n); i++)
        if (n % i == 0)
            return false;
    return true;
}
int sum(int a[], int n)
{
    int tmp = 0;
    for (int i = 0; i < n; i++)
        tmp += a[i];
    return tmp;
}



int main()
{
    system("cls");
    int a[101];
    int n;
    cin >> n;
    cout << sum(a, 2);
    
}
