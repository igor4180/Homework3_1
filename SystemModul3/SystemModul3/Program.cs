using System.Threading;
using System.Text;
using System.ComponentModel;

namespace HW_SP3
{
    //Создайте оконное приложение, генерирующее набор простых чисел в диапазоне, указанном пользователем.
    //Если не указана нижняя граница, поток с стартует с 2.Если не указана верхняя граница, генерирование про-
    //исходит до завершения приложения.Используйте механизм потоков. Числа должны отображаться в оконном интерфейсе.
    internal class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject(Int32.Parse(Console.ReadLine()));
            myObject.Start = Int32.Parse(Console.ReadLine());
            myObject.End = Int32.Parse(Console.ReadLine());
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(ConsoleWrite);
            ThreadStart threadStart = new ThreadStart(ConsoleWrite);//применяется к первой задаче
            Thread thread = new Thread(threadStart);
            //for (int i = 0; i < myObject.threads.Length; i++)
            //{
            //    myObject.threads[i] = new Thread(parameterizedThreadStart);
            //}
            int i = 0; 
            while (i < myObject.threads.Length)
            {
                myObject.threads[i] = new Thread(parameterizedThreadStart);
                Console.Write (i);
                i++;
            }
            //for (int i = 0; i < myObject.threads.Length; i++)
            //{
            //    myObject.threads[i].Start(myObject);
            //    myObject.threads[i].Join();
            //}
            while (i < myObject.threads.Length)
            {
                myObject.threads[i].Start(myObject);
                myObject.threads[i].Join();
                i++;
            }
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start(myObject);
            thread.Join();
            //for (int i = 0; i <= 50; i++)
            //{
            //    Console.WriteLine("Из основной программы: " + i);
            //}
            do
            {
                Console.WriteLine("Из основной программы: " + i);
                i++;
            } while (i <= 50);
            
        }
        static void ConsoleWrite()
        {
            Console.WriteLine("Введите число начала массива");//первый вариант вывода заданого диапазона потока
            int istart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число конца массива");
            int iend = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= 50; i++)
            {
                if (i == 25)
                {
                    Console.ReadLine();
                }
                Console.WriteLine("Из потока: " + i);
            }
        }

        static void ConsoleWrite(object my)
        {
            int start = ((MyObject)my).Start;
            int end = ((MyObject)my).End;
            string message = ((MyObject)my).Message;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("Из потока: " + i);
            }
            Console.WriteLine();
        }
        static void SaveDataToFile(object number)
        {
            FileStreamOptions options = new FileStreamOptions();
            options.Access = FileAccess.Write;
            options.Share = FileShare.Write;
            options.Mode = FileMode.OpenOrCreate;
            StreamWriter writer = new StreamWriter("task5.txt", Encoding.UTF8, options);
            writer.WriteLine(number.ToString());
            writer.Close();
        }
    }
    class MyObject
    {
        public int Start { get; set; }
        public int End { get; set; }
        public string Message { get; set; } = "Это читерство";
        public Thread[] threads;
        public MyObject(int countThread)
        {
            if (countThread > 0)
            {
                threads = new Thread[countThread];
            }
            else
            {
                threads = new Thread[1];
            }
        }
    }
}