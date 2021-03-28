using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_2_Task_2
{
    class Timer
    {
        private Task timerThread;
        private object _lock;
        private CancellationTokenSource cancellationTokenSource;

        public Action Action { get; private set; }

        private TimeSpan _Interval;
        public TimeSpan Interval
        {
            get
            {
                return _Interval;
            }
            set
            {
                if (value.TotalMilliseconds < 50)
                {
                    throw new ArgumentException("Inteval is too short, minimum is 50 ms");
                }
                _Interval = value;
            }
        }

        private bool isActive = false;

        public void Start()
        {
            if (!isActive)
            {
                isActive = true;
                Monitor.Exit(_lock);
            }
        }

        public void Stop()
        {
            if (isActive)
            {
                isActive = false;
                Monitor.Enter(_lock);
            }
        }

        public void Cancel()
        {
            cancellationTokenSource.Cancel();
        }

        public Timer(TimeSpan interval, bool start, Action action)
        {
            Action = action;
            Interval = interval;
            _lock = new object();
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken ct = cancellationTokenSource.Token;
            Monitor.Enter(_lock);
            timerThread = Task.Run(() =>
            {
                while(true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        return;
                    }
                    lock (_lock)
                    {
                        Action();
                    }
                    Thread.Sleep(interval);
                }
            }, ct);

            if (start)
            {
                Start();
            }
        }
    }
}
