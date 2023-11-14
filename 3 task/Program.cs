 
Console.WriteLine("Введите число");
int num1=Convert.ToInt32(Console.ReadLine());
int[] array1=new int[10] { 12 ,-47, -87, -98, 8 ,71 , 6, -52 ,21 , 7 };

for(int i = 0;i<10;i++)
{
if (array1[i] == num1) Console.WriteLine("такое число имеется в массиве");
else Console.WriteLine("такое число не имеется в массиве");
}