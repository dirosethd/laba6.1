int a, b;
Console.Write("Введите числитель дроби: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите знаменатель дроби: ");
b = int.Parse(Console.ReadLine());

int Ks = NIK(a, b);
int s = a / Ks;
int l = b / Ks;

Console.WriteLine($"Сокращенная дробь: {s}/{l}");

static int NIK(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
