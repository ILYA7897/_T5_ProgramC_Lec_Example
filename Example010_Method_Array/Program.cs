// Поиск в массиве номера позиции на которой находится элемент FIND(MAX)
int [] array = {1, 12, 32, 4, 45, 23, 16, 18} ;

int n = array.Length ;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index) ;
//        break
    }
    index ++ ;
}