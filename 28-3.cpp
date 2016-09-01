#include<stdio.h>
#include<map>
using namespace std;
#define MOD 6000011
char h[MOD];
int v[MOD],vv[MOD],T;
void ins(int x,int val){
	int hx = x % MOD;
	while(h[hx]==T && v[hx]!=x){
		hx++;
		if(hx==MOD)hx=0;
	}
	h[hx]=T;
	v[hx]=x;
	vv[hx]=val;
}
int fd(int x){
	int hx = x % MOD;
	while(h[hx]==T && v[hx]!=x){
		hx++;
		if(hx==MOD)hx=0;
	}
	if(h[hx]!=T)return -1;
	return vv[hx];
}
int main(){
	int n,a,b;
	for(T=1; ~scanf("%d",&n) && n; T++){
		scanf("%d%d",&a,&b);
		ins(0,0);
		int s = 0, z = 0;
		while(1){
			z = (int)(((long long int)z*z%n*a+b)%n);
			++s;
			int val = fd(z);
			if(val != -1){
				printf("%d\n",n-(s-val));
				break;
			}else{
				ins(z,s);
			}
		}
	}
	return 0;
}
