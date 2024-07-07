namespace _21_Async
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var task1 = StartSchool();
            var task2 = TeachClass11();
            var task3 = TeachClass12();

            Task.WaitAll(task1, task2, task3);
        }

        public static async Task StartSchool()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Okul başladı");
                Thread.Sleep(8000);
                Console.WriteLine("Okul bitti");
            });
        }

        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("12. sınıf başladı");
                Thread.Sleep(3000);
                Console.WriteLine("12. sınıf bitti");
            });
        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("11. sınıf başladı");
                Thread.Sleep(2000);
                Console.WriteLine("11. sınıf bitti");
            });
        }

    }
}
