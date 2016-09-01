#include<stdio.h>
#include<math.h>
int main(){
	double a,b,c;
	while(~scanf("%lf%lf%lf",&a,&b,&c) && a>0){
		double delta = b * b - 4 * a * c;
		if (delta <= 0)
		{
			printf("%.4lf\n",0.0);
			continue;
		}
		delta = sqrt(delta);
		double l = (-b - delta) / (2 * a);
		double r = (-b + delta) / (2 * a);
		printf("%.4lf\n", (a * l * l * l / 3 + b * l * l / 2 + c * l) - (a * r * r * r / 3 + b * r * r / 2 + c * r));
	}
	return 0;
}
