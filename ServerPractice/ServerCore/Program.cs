namespace ServerCore
{
    class Program
    {
        static void MainThread(object state)
        {
            for(int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Hello Thread!");
            }
        }

        static void Main(string[] args)
        {
            // 백그라운드
            //ThreadPool.QueueUserWorkItem(MainThread);


            for(int i = 0; i< 1000; ++i)
            {
                Thread t = new Thread(MainThread);
                t.IsBackground = true;
                t.Start();
            }
            //t.Join();
            //Console.WriteLine("Hello World!");
        }
    }
}