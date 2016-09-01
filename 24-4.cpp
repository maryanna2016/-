#include<stdio.h>
#include<string.h>
#include<algorithm>
using namespace std;
int a[8],b[8];
int main(){
	int n;
	while(~scanf("%d",&n) && n){
		for(int i=0; i<n; i++){
			scanf("%d",&a[i]);
			b[i] = i+1;
		}
		int r = 0;
		while(memcmp(a,b,sizeof(int)*n)!=0){
			next_permutation(b,b+n);
			r++;
		}
		printf("%d\n",r);
	}
	return 0;
}
