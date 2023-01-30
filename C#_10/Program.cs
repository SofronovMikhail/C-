int [] array = {16, 34, 4, 12, 56, 3, 55, 98, 12};
int n = array.Length;
int find = 12;
int i = 0;
while(i < n){
    if(array[i] == find){
        Console.WriteLine(i); 
        break;
    }
    i++;
}

