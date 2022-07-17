int[] array = { 1, 23, 31, 34, 80, 52, 46, 74, 80 };
int n = array.Length;
int find = 80;

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