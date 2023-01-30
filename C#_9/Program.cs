Console.Clear();
int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int [] array = {16, 34, 4, 11, 56, 3, 55, 98, 12};
array[7] = 5;
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);

