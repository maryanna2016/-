long long int ans;
int n,a[555555],t[555555];
void mergesort(s,e)
{
	int m,i,j,k;
	if(s+1==e)return;
	m=(s+e)/2;
	mergesort(s,m);
	mergesort(m,e);
	for(i=s,j=m,k=s; i<m || j<e;)
	{
		for(; i<m && (j==e || a[i]<a[j]); t[k++]=a[i++]);
		for(; j<e && (i==m || a[j]<a[i]); t[k++]=a[j++])
			ans+=m-i;
	}
	memcpy(a+s,t+s,sizeof(int)*(e-s));
}
main()
{
	int i;
	while(~scanf("%d",&n) && n)
	{
		for(i=0; i<n; i++)
			scanf("%d",&a[i]);
		ans=0;
		mergesort(0,n);
		printf("%I64d\n",ans);
	}
	return 0;
}