// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int[] GetCubeNumber(int number)
{
    int[] cubeNumbers = new int[number];

    for (int i = 1; i <= number; i++)
    {
        cubeNumbers[i - 1] = (i * i) * i;
    }

    return cubeNumbers;
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubeNumber(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}
