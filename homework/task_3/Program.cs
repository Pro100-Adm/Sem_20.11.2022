int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

int [] fill_array(int num){
    int [] arr = new int [num];
    for (int i = 0; i<num; i++){
        arr[i]=AskUser();
    }
    return arr;
}

void print_array(int [] arr){ 
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length-1]);
    Console.Write("]");
}

print_array(fill_array(8));
