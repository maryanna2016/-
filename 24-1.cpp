#include<stdio.h>
#include<algorithm>
using namespace std;
int a[1111];
int main(){
	int n,t;
	scanf("%d%d",&n,&t);
	while(t--){
		for(int i=0; i<n; i++)
			scanf("%d",&a[i]);
		next_permutation(a,a+n);
		for(int i=0; i<n; i++)
			printf("%d%c",a[i],i<n-1?' ':'\n');
	}
	return 0;
}
