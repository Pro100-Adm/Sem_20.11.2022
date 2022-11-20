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

double Summ_nums(double num){
    double num_length = Math.Floor(Math.Log10(num))+1;
    double summ_nums = 0;
    for(int i = 0; i<num_length; i++){
        double last_num = num%10;
        num = Math.Floor(num/10);
        summ_nums+=last_num;
    }
    return summ_nums;
}

Console.WriteLine(Summ_nums(AskUser()));