#include<stdio.h>
int n,b,a[555555];
bool chk(int x){
	int tot = b;
	for(int i=1; i<=n; i++){
		tot -= ((a[i]-1) / x + 1);
		if(tot < 0)
			return false;
	}
	return true;
}
int main(){
	while(~scanf("%d%d",&n,&b) && n!=-1){
		int lo = 1, hi = 0;
		for(int i=1; i<=n; i++){
			scanf("%d",&a[i]);
			if(a[i] > hi) hi = a[i];
		}
		while(lo!=hi){
			int mi = (lo + hi)/2;
			if(chk(mi))
				hi=mi;
			else
				lo=mi+1;
		}
		printf("%d\n",lo);
	}
	return 0;
}