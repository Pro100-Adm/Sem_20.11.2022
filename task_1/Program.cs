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

void sum(double num){
    double summ = 0;
    for (int i = 0; i<=num; i++){
        summ += i;
    }
Console.WriteLine(summ);
}

sum(AskUser());