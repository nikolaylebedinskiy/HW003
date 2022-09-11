System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

while(a <= N) {
    System.Console.WriteLine(a * a * a);
    a++;
}
