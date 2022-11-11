#include <bits/stdc++.h>
using namespace std;
int n, m;
int a[1001][1001]; //Ma trận kề
vector<int>adj[1001];//Danh sách kề

// tạo 1 vector để lưu các cạnh
vector<pair<int, int>>edges; //Danh sách cạnh
int main(){
    system("cls");
    cin >> n;
    cin.ignore();
    for (int i = 1; i <= n; i++){
        string s, num;
        getline(cin, s);
        stringstream ss(s);
        while (ss >> num){
            if (stoi(num) > i){
                edges.push_back({i, stoi(num)});
            }
        }
    }
    for (auto i : edges){
        cout << i.first << " " << i.second << '\n';
    }
    return 0;
}
