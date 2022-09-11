System.Console.WriteLine("Введите 5-тизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int A = N;
int dig = 0;
int rev = 0;

while (N >0) {
    dig = N % 10;
    rev = rev * 10 + dig;
    N = N / 10;
}
if (A == rev){
    System.Console.WriteLine("Число является палиндромом");
}
else {
    System.Console.WriteLine("число не является палиндромом");
}
