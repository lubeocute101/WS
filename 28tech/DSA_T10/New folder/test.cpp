#include <bits/stdc++.h>
using namespace std;
using ll = long long;
int n, cnt, a[100];
bool final = false;
void init() {
    cnt = 1;
    a[1] = n;
}
void gen() {
    // di tim so hang dau tien khac 1
    int i = cnt;
    while (i >= 1 && a[i] == 1) --i;
    if (i == 0) final = true;
    else {
        a[i]--;
        int tmp = cnt - i + 1; // so luong so 1 da bo qua
        cnt = i;
        //bieu dien tmp thong qua a[i]
        int q = tmp / a[i], r = tmp % a[i];
        for (int j = 1; j <= q; j++) {
            a[++cnt] = a[i];
        }
        if (r != 0) { //tmp chia du cho a[i] 1 don vi => bo sung 1 vao cuoi
            a[++cnt] = r;            
        }
    }
}
int main()
{
    // #ifndef ONLINE_JUDGE
    // freopen("input.txt", "r", stdin);
    // freopen("output.txt", "w", stdout);
    // #endif
    // ios_base::sync_with_stdio(false);
    // cin.tie(nullptr); 
    cout <<"N = "; cin >> n;
    init();
    while (!final)
    {   
        cout << n << " = ";
        for (int i = 1; i <= cnt; i++)
        {
            if (i == cnt) cout << a[i];
            else cout << a[i] << "+";
        }
        cout << endl;
        gen();
    }
    
}
