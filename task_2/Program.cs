double AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
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

double col(double num){
    double num_length = Math.Floor(Math.Log10(num))+1;  
    return num_length;
}

Console.WriteLine(col(AskUser()));