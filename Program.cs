          // Выполнение итогового задаания по 1-й четверти.
          // Написать программу, которая из имеющегося массива строк формирует массив строк,
          // длина которых меньше или равна 3 символам. Првоначальный массив можно задать с клавиатуры,
          // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
          // коллекциями, лучше обойтись исключительно массивами.
const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789^!?-+=_()*&|%$#@";
Random RundNum = new Random();
int StringNumbers = RundNum.Next(3,11);
string[] StringMas, ResultMas;
StringMas = new string[StringNumbers];
ResultMas = new string[StringNumbers];

          // Генерация строк.  
for (int i=0; i<StringMas.Length; i++) {
    int CurrentStrLength = RundNum.Next(1,8);
    StringMas[i] = new string(Enumerable.Repeat(Chars, CurrentStrLength).Select(s => s[RundNum.Next(s.Length)]).ToArray());
}
Console.WriteLine("Число элементов-строк во входном массиве - {0} :", StringNumbers);
Console.Write("[");
Console.Write(String.Join(", ", StringMas));
Console.WriteLine("]\n");
          // Создание копии массива и удаление из нее строк с длиной, превышающей заданную.
ResultMas = StringMas;
for (int i=0; i<StringMas.Length; i++) 
  if (StringMas[i].Length > 3) ResultMas = ResultMas.Where(e => e != StringMas[i]).ToArray();

Console.WriteLine("Число элементов-строк во выходном массиве - {0} :", ResultMas.Length);
Console.Write("[");
Console.Write(String.Join(", ", ResultMas));
Console.WriteLine("]\n");