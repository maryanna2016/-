#include<cstdio>
#include<algorithm>
using namespace std;

int a,b,c;

int main() {
	scanf("%d%d%d", &a, &b, &c);
	printf("%d\n", max(max(a+b, a+c), b+c));
	
	return 0;
}