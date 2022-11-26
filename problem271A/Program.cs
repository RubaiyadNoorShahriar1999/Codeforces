int year;
year = Convert.ToInt32(Console.ReadLine());

while (true)
{
    year += 1;
    int first_digit = year / 1000;
    int second_digit = year / 100 % 10;
    int third_digit =  year / 10 % 10;
    int last_digit = year % 10;

    if (first_digit != second_digit && first_digit != third_digit && first_digit != last_digit && second_digit != third_digit && second_digit != last_digit && third_digit != last_digit)
        break;

}
Console.WriteLine(year);