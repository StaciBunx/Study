int[] array = { 1, 22, 31, 4, 56, 16, 4 , 71, 84 };
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}