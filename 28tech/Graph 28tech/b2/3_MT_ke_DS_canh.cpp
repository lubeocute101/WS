#include <bits/stdc++.h>
using namespace std;
int n, m;
int a[1001][1001]; //Ma trận kề
vector<int>adj[1001]; 

// tạo 1 vector để lưu các cạnh
vector<pair<int, int>>edges;
int main(){
    system("cls");
    cin >> n;
    for (int i = 1; i <= n; i++){
        for (int j = 1; j <= n; j++){
            cin >> a[i][j];
        }
    }
    for (int i = 1; i <= n; i++){
        for (int j = 1; j <= n; j++){
            if (a[i][j] && i < j){
                edges.push_back({i, j});
            }
        }
    }
    for (auto i : edges){
        cout << i.first << " " << i.second << endl;
    }
    return 0;
}
