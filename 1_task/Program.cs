int[] array1 = new int[12];
int pos = 0;
int neg = 0;
for(int i=0;i<12;i++)
{
array1[i]=new Random().Next(-9,10);
Console.Write(array1[i]+" ");
if ( array1[i]>0) pos = pos + array1[i];
else if ( array1[i]<0) neg = neg + array1[i];
}

Console.WriteLine(neg);
Console.WriteLine(pos);


