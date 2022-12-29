Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while(n / 10 > 0){
    result = n % 10 + result;
    n /= 10;
}
result += n;
Console.WriteLine($"Сумма цифр в числе: {result}");