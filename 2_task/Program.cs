

int[] array1=new int[10] { 12 ,-47, -87, -98, 8 ,71 , 6, -52 ,21 , 7 };
int neg = 0;
for (int i=0;i<10;i++) 
{
if (array1[i]>0) neg = array1[i] * (-1);
if (array1[i]<0) neg = array1[i] * (-1);
Console.Write(neg+" ");
}


