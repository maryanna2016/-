#include<stdio.h>
#include<algorithm>
using namespace std;
double a[17777];int n;
int main(){
	while(~scanf("%d",&n)){
	for(int i=0; i<n; i++)
		scanf("%lf",&a[i]);
	sort(a,a+n);
	double r=0,s=0;
	for(int i=0; i<n; i++){
		r+=s;
		s+=a[i];
	}
	printf("%.2lf\n",r/n);
	}
	return 0;
}
