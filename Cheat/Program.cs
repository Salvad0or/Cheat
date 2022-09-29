


// 504 стр.

namespace Cheat
{
    #region Расширения

    

    static class TestRas
    {
        public static void TestRashir(this int a)
        {
            Console.WriteLine("STATY");
            
        }
    }

    #endregion

    #region Делегаты
    delegate int SimpleMath(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW");

            car.Exploded += TestEvnet;

            void TestEvnet(object sender, CarEventArgs e)
            {
                Console.WriteLine($"{(sender as Car).Name} сказал {e.message}");
            }

            void TestEvent2(object sender, CarEventArgs e)
            {
                Console.WriteLine(1 + 1);
            }

            car.Exploded += TestEvent2;
        

            car.Message();


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

    #region События

    public class CarEventArgs : EventArgs
    {

        public readonly string message;

        public CarEventArgs(string m)
        {
            message = m;
        }
    }

    public class Car
    {
        public delegate void CarEngineHanlder(object sender, CarEventArgs e);

        public event CarEngineHanlder Exploded;
        public event CarEngineHanlder AboutToBlow;

        public string Name { get; set; }

        public void Message()
        {
            Exploded?.Invoke(this, new CarEventArgs("Test"));
        }

        public Car(string name)
        {
            Name = name;
        }
       
    }

    public class Start
    {
        void StartEvent(object sender, CarEventArgs e)
        {
            Console.WriteLine(sender + "says" + e.message);
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

    #region Многопотчность

    class Threads
    {
   
        void Main()
        {
            /// Создание дополнительного потока
            Thread task = new Thread(Method1);

            /// Поток принимающий в себя делегат который ничего не возвращяет, параметром принимает obj.
            /// В этот самый обж можем сувать что угодно
            Thread task2 = new Thread(new ParameterizedThreadStart(Method2));

            /// Запуск самих потоков соответственно
            task.Start();
            task2.Start("123");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("-");

            }
        }

        void Method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+");

            }
        }

        void Method2(object p)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write(p);
            }
        }

}

    #endregion
}



