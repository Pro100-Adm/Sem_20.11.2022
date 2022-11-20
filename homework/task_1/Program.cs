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

double make_power(double num, double power){
    double powered_num = 1;
    for(int i = 0; i<power; i++){
        powered_num*= num;
    } 
    return powered_num;
}

Console.WriteLine(make_power(AskUser(), AskUser()));