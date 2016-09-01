#include<cstdio>

const int go[8][2] = {0,1,1,0,0,-1,-1,0,1,1,1,-1,-1,1,-1,-1};

int n,m;
int s[1111][1111];
int q[1111111];

void bfs(int x,int y){
int l = 0, r = 0;
q[r++] = x; q[r++] = y;
s[x][y]=0;
while(l<r) {
int a = q[l++], b=q[l++];
for(int i=0;i<8;i++){
int _a=a+go[i][0],_b=b+go[i][1];
if(_a<0||_a>=n||_b<0||_b>=m||s[_a][_b]==0)continue;
s[_a][_b]=0;
q[r++]=_a;q[r++]=_b;
}
}
}

int main() {
scanf("%d%d", &n,&m);
for(int i=0;i<n;i++)
for(int j=0;j<m;j++)
scanf("%d",&s[i][j]);
int ans=0;
for(int i=0;i<n;i++)
for(int j=0;j<n;j++)
if(s[i][j]!=0) {
ans++;
bfs(i,j);
}
printf("%d\n", ans);
return 0;
}