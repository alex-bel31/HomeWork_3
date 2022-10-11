// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string PrintAndGetValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    return input;
}
string digit = PrintAndGetValue("Введите пятизначное число");

void isPalindrom(string digit)
{
    if(digit[0] == digit[4] && digit[1] == digit[3]) Console.WriteLine($"{digit}->да");
    else Console.WriteLine($"{digit}->нет");
    
   
}
isPalindrom(digit);


