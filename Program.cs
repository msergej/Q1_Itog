          // Выполнение итогового задаания по 1-й четверти.
          // Написать программу, которая из имеющегося массива строк формирует массив строк,
          // длина которых меньше или равна 3 символам. Првоначальный массив можно задать с клавиатуры,
          // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
          // коллекциями, лучше обойтись исключительно массивами.
Random RundNum = new Random();
int StringNumbers = RundNum.Next(3,8);
string[] StringMas;
StringMas = new string[StringNumbers];
/*
int B = RundNum.Next(-9,10);
int Product = 0;
*/
Console.WriteLine(StringMas[0]);

/*
for(int i=2; i<10; i++) 
    for(int j=2; j<10; j++)
        Console.WriteLine($"{i} * {j} = {i * j}");


//    string res = Method_04(3, "A");
//    Console.WriteLine(res);
//    Console.WriteLine("Hello, World! #2");



static string Method_04(int count, string c) {
    int i = 0;
    string result = string.Empty;
    while (i < count) {
        result = result + c;
        i++;
    }
    return result;
}      
*/

