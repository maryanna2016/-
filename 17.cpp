#include<stdio.h>
#include<queue>
using namespace std;
int main(){
	char s[99];
	deque<int> q;
	while(~scanf("%s",s)&&*s!='e'){
		if(*s=='i'){
			int t;
			for(scanf("%d",&t); t--;){
				int x,y;
				scanf("%d%d",&x,&y);
				--x;
				q.insert(q.begin()+x,y);
			}
		}else
		if(*s=='c'){
			q.clear();
		}else{
			int x;
			scanf("%d",&x);
			--x;
			printf("%d\n",q[x]);
			if(*s=='d'){
				q.erase(q.begin()+x);
			}
		}
	}
	return 0;
}