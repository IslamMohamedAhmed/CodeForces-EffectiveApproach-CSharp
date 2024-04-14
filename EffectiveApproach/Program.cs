using static System.Console;
using static System.Convert;
using static System.Math;


long n, m,mainCounter1 = 0,mainCounter2 = 0,secCounter;
long[] arr1 = new long[100001];
long[] arr2 = new long[100001];



n = ToInt64(ReadLine());
string str1 = ReadLine();
var arr3 = str1.Split(" ");
for(long i = 0; i < n; i++)
{
    arr1[ToInt64(arr3[i])] = i+1;
}
m = ToInt64(ReadLine());
string str2 = ReadLine();
var arr4 = str2.Split(" ");
for(long j = 0; j < m; j++)
{
    arr2[j] = ToInt64(arr4[j]);
    mainCounter1 += arr1[arr2[j]];
    mainCounter2 += n - arr1[arr2[j]]+1;
  

}

WriteLine($"{mainCounter1} {mainCounter2}");


