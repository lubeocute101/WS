#include <bits/stdc++.h>
using namespace std;
int n, m;
int a[1001][1001]; //Ma trận kề
vector<int>adj[1001]; //Ds kề
// adj[i]: lưu danh sách kề của đỉnh i

int main(){
    system("cls");
    cin >> n >> m;
    for (int i = 0; i < m; i++){
        int x, y; cin >> x >> y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    for (int i = 1; i <= n; i++){
        cout << i << " : ";
        for (int x : adj[i]){
            cout << x << " ";
        }
        cout << '\n';
    }
    return 0;
}
