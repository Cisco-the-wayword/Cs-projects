using System;

namespace StopwatchApp
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _isRunning = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            _isRunning = false;
            _stopTime = DateTime.Now;
        }

        public TimeSpan GetDuration()
        {
            return _stopTime - _startTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("Press any key to start the stopwatch, or 'q' to quit.");
                var input = Console.ReadLine();

                if (input == "q")
                    break;

                try
                {
                    stopwatch.Start();
                    Console.WriteLine("Stopwatch started.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Press any key to stop the stopwatch.");
                Console.ReadKey();

                try
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Duration: {stopwatch.GetDuration()}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
