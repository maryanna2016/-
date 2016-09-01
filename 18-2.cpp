#define MAX 1111111
bool f[MAX];
int p[111111],lp;
void init(){
	for(int i=2; i<MAX; i++){
		if(!f[i]){
			p[lp++]=i;
		}
		for(int j=0; j<lp; j++){
			int t=i*p[j];
			if(t>=MAX)break;
			f[t]=true;
			if(i%p[j]==0)break;
		}
	}
}

#include<stdio.h>
#include<algorithm>
using namespace std;
int main(){
	init();
	int x,y;
	while(~scanf("%d%d",&x,&y)){
		int*start = lower_bound(p,p+lp,x);
		int*end = upper_bound(p,p+lp,y);
		int cnt = 0;
		for(int*it = start; it < end; it++){
			printf("%d",*it);
			cnt++;
			if(it == end - 1 || cnt == 10){
				puts("");
				cnt=0;
			}else
				printf(" ");
		}
		puts("");
	}
	return 0;
}