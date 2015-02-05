using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace stopwatch_MVP
{
    
    class Model
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public int a = 0;
        public int b = 0;
        public int c = 0;
        public string str;

        public Model()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
             str = c.ToString() + " ч : " + b.ToString() + " мин : " + a++.ToString() + " сек";
            if ((a%60)==0)
            {
                a = 0;
                str = b++.ToString() + " : " + a++.ToString();
                if ((b%60)==0)
                {
                    a = 0;
                    b = 0;
                    str = c++.ToString() + " : " + b++.ToString() + " : " + a++.ToString();
                }
            }
            
        }

        public string Clear()
        {
            a = 0; b = 0; c = 0;
            timer.Stop();
            return c.ToString() + " ч : " + b.ToString() + " мин : " + a.ToString() + " сек";
            
        }
      

       

        
    }
}
