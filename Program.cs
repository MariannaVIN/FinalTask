// написать прогамму, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символам.

Console.WriteLine("Введите символы в строку:");
string Number = Console.ReadLine();

void Quantity3 (string Number)
{
    int count = Number.Length;
    if(Number.Length <=3)
    {Console.WriteLine(Number);}
    else 
    {Console.WriteLine(" ");}
}

Quantity3 (Number);
