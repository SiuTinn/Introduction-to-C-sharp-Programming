using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时时或者响铃时，在控制台显示提示信息。


namespace Program2
{
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);

    public class ClockEventArgs : EventArgs
    {
        public DateTime CurrentTime { get; set; }
    }

    public class Clock
    {
        public event ClockEventHandler Tick;
        public event ClockEventHandler Alarm;

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnTick(new ClockEventArgs { CurrentTime = DateTime.Now });
                if(DateTime.Now.Second == 0 || DateTime.Now.Second == 30)
                {
                    OnAlarm(new ClockEventArgs { CurrentTime = DateTime.Now });
                }

            }
        }

        protected virtual void OnTick(ClockEventArgs e)
        {
            Tick?.Invoke(this, e);
        }

        protected virtual void OnAlarm(ClockEventArgs e)
        {
            Alarm?.Invoke(this, e);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            // 订阅Tick事件
            clock.Tick += (sender, e) =>
            {
                Console.WriteLine($"Tick: {e.CurrentTime}");
            };

            // 订阅Alarm事件
            clock.Alarm += (sender, e) =>
            {
                Console.WriteLine($"Alarm: {e.CurrentTime} - Wake up！");
            };

            clock.Start(); // 启动时钟
        }
    }

}
