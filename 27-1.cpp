#include<stdio.h>
#include<iostream>
using namespace std;
double doit(){
	char s[99];
	if(scanf("%s",s) == EOF) exit(0);
	if(*s=='*' || *s=='+' || *s=='-' || *s=='/'){
		double op1 = doit();
		double op2 = doit();
		if(*s == '*')
			return op1 * op2;
		if(*s == '+')
			return op1 + op2;
		if(*s == '-')
			return op1 - op2;
		return op1/op2;
	}
	double x;
	sscanf(s,"%lf",&x);
	return x;
}
int main(){
	while(1){
		printf("%lf\n",doit());
	}
	return 0;
}
