#include <bits/stdc++.h>
using namespace std;
using ll = long long;
/*-comparator
    +true: nếu x là thằng đứng trước, y là thằng đứng sau
đã sắp xếp đúng thứ tự mà bạn mong muốn sau khi sắp xếp => true;
    +false: nếu x là thằng đứng trước, y là thằng đứng sau
ngược thứ tự mà bạn mong muốn => false; 
*/
int tong(int x){
    int sum = 0;
    while (x)
    {
        sum += x % 10;
        x /= 10;
    }
    return sum;
    
}
bool cmp (int x, int y){
   int t1 = tong(x), t2 = tong(y);
   if (t1 != t2) return t1 > t2;
   return x > y;
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
    int a[n];
    for (int i = 0; i < n; i++) cin >> a[i];
    cout << "max = " << *min_element(a, a + n) << endl;
    cout << "min = " << *max_element(a, a + n) << endl;
    cout << "accumulate = " << accumulate(a, a + n, 0) << endl;
    reverse(a, a + n);
    cout << "reverse = ";   for (int x : a) cout << x << " ";
}
