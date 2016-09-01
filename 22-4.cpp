#include<stdio.h>
int ax[5555],bx[5555],ay[5555],by[5555];
int main(){
	int n;
	while(~scanf("%d",&n) && n){
		for(int i=0; i<n; i++)
			scanf("%d%d%d%d",&ax[i],&bx[i],&ay[i],&by[i]);
		int cnt=0;
		for(int i=0; i<n; i++){
			bool flag=false;
			for(int j=0; j<n; j++)if(j!=i && 
				ax[i] >= ax[j] && 
				bx[i] <= bx[j] && 
				ay[i] >= ay[j] && 
				by[i] <= by[j]
				){
				flag=true;
				break;
			}
			if(flag)cnt++;
		}
		printf("%d\n",cnt);
	}
	return 0;
}