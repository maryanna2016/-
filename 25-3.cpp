#include<stdio.h>
#include<algorithm>
using namespace std;
int a[44];int n,tot;
void p(int x,int y){
	int r = 1;
	for(int i=0; i<y; i++){
		if(r > 2500000/x){
			tot = -1;
			return;
		}
		r*=x;
	}
	tot += r;
	if(tot > 2500000){
		tot = -1;
		return;
	}
}
int main(){
	int t;
	for(scanf("%d",&t); t--;){
		for(n=0;;n++){
			scanf("%d",&a[n]);
			if(a[n]==0)break;
		}
		sort(a,a+n);
		tot=0;
		for(int i=n-1; i>=0; i--){
			p(a[i],n-i);
			if(tot == -1)break;
		}
		if(tot == -1)
			puts("Too expensive");
		else
			printf("%d\n",tot*2);
	}
	return 0;
}
