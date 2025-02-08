namespace _04MemberVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

class Player
{
    // 멤버변수
    // 세부속성이면서 명사이면서 값
    bool IsFight;
    int Gold = 10;
    int Exp = 1000;
    int Att = 300;
    int Def = 100;
    int Hp = 400;
}