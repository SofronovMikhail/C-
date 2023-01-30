void Function1(int[] array1){
    int length = array1.Length;
    int i = 0;
    while(i < length){
        array1[i] = new Random().Next(1,10);
        i++;
    }
}
void Function2(int[] array2){
    int length1 = array2.Length;
    int index = 0;
    while(index < length1){
        Console.WriteLine(array2[index]);
        index++;
    }
}
int Function3(int[] array1, int find){
    int length = array1.Length;
    int i = 0;
    int position = -1;
    while(i < length)
    {
        if(array1[i] == find)
        {
            position = i;
        }
        i++;
    }
    return position;
}
int[] array = new int[10];
Function1(array);
Function2(array);
Console.WriteLine();
int result = Function3(array, 4);
Console.WriteLine(result);