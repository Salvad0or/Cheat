


// 504 стр.

namespace Cheat
{
    #region Расширения
    static class TestRas
    {
        public static void TestRashir(this int a)
        {
            Console.WriteLine(a);
        }

    }

    #endregion

    #region Делегаты
    delegate int SimpleMath(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            #region Func, Action

            Func<int, int, string> stringMath;

            stringMath = MathString;

            string result = stringMath?.Invoke(1, 2);

            Action<int, int> actionMath;

            actionMath = Math;

            #endregion

            #region Отправка метода делегату
            Druid druid = new Druid(50, Message);

            for (int i = 0; i < 100; i++)
            {
                druid.GetDammage(10);
                if (druid.isDeath) break;
            }
            #endregion

            #region Создание простого делегата

            //SimpleMath simple = Math;

            //int x = simple.Invoke(1, 2);

            //Console.WriteLine(x);

            #endregion
        }

        public static void Math(int x, int y) { int b = x + y; }

        public static string MathString(int x, int y) => (x + y).ToString();

        public static void Message(string a)
        {
            Console.WriteLine("War started!");

            Console.WriteLine(a);
        }
    }

   

    #endregion

    #region Generic

    class Generics
    {
        static void Test<T>(Persons<T> p)
        {
            switch (p)
            {
                case Persons<string> PP:
                    Console.WriteLine("This is string type");
                    break;
                case Persons<int> Pi:
                    Console.WriteLine("This is int type");
                    break;
                default:
                    Console.WriteLine("This type havent string and int type");
                    break;

            }
        }
    }


    class Persons<T>
    {
        public T y { get; set; }

        public T X { get; set; }

        public Persons(T y, T x)
        {
            this.y = y;
            X = x;
        }
    }

    #endregion

}



