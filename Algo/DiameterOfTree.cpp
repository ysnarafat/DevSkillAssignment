/// Bismillahir Rahmanir Rahim.
/// All that goods comes from Allah(SWT).

#include<bits/stdc++.h>
#define soclose 1e-5
#define pi 3.14159265358979323846
using namespace std;
void chill()
{
    ios_base::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);
}
bool vis[100];
vector<int>v[100]
void dfs(int n)
{
    vis[n]=1;
    for(int i=0;i<v[n].size();i++){
        if(vis[v[n][i]]==0) {
                cnt++;
                dfs(v[n][i]);
        }
    }

}

int main()
{
    chill();
    ///freopen("in.txt","r",stdin);
    ///freopen("out.txt","w",stdin);
    int n;
    cin>>n;
    for(int i=1;i<n;i++){
        cin>>a>>b;
        v[a].push_back(b);
        v[b].push_back(a);
    }
    dfs(1);
    dfs();
    return 0;
}
/// Pera Nai, Just Chill !!!
/// AC hoile ki ar na hoileo ki, Just Chill !!!


