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

void prod(double num){
    double res = 1;
    for (int i = 1; i<=num; i++){
        res *= i;
    }
Console.WriteLine(res);
}

prod(AskUser());