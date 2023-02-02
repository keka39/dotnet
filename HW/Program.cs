Console.Clear();
int[] numbers = {2, 5, 13, 7, 6, 4};
float size = 6f;
float sum = 0F;
float avg = 0F;
int index = 0;

while(index < size)
{
    sum += numbers[index];
    index++;
}
avg = sum / size;
System.Console.WriteLine(avg);