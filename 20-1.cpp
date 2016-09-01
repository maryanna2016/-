#include<stdio.h>
#include<string>
#include<map>
using namespace std;
map<long long int,string> Map;
long long int h(char*x){
	long long int r = 1;
	for(int i=0; x[i]; i++)
		r = r * 197 + x[i];
	return r;
}
int main(){
	char x[111],y[111];
	string Y;
	int n;
	for(scanf("%d",&n); n--;){
		scanf("%s%s",x,y);
		Y=y;
		Map[h(x)]=Y;
	}
	for(scanf("%d",&n); n--;){
		scanf("%s",x);
		long long int W = h(x);
		if(Map.count(W))
			puts(Map[W].c_str());
		else
			puts("can't find");
	}
	return 0;
}