import java.io.*;
import java.util.*;
import java.math.*;

public class Main
{
	public static void main(String args[]) throws Exception
	{
		BigInteger[] a = new BigInteger[101];
		a[0] = BigInteger.ONE;
		for(int i=1; i<=100; i++){
			a[i] = a[i-1].multiply(new BigInteger(new Integer(i).toString()));
		}
		Scanner cin = new Scanner(System.in);
		while(true){
			int x = cin.nextInt();
			if(x < 0) break;
			System.out.println(a[x].toString());
		}
	}
}