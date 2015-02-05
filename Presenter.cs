using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch_MVP
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;
            view.Start += view_Start;
            view.Stop += view_Stop;
            view.Clear += view_Clear;
            model.timer.Tick += timer_Tick;
            model.timer.Start();
            model.timer.IsEnabled = false;
        }

        void view_Clear(object sender, EventArgs e)
        {
            view.textBoxTimer.Text = model.Clear();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            view.textBoxTimer.Text = model.str;
        }

        void view_Stop(object sender, EventArgs e)
        {
            model.timer.IsEnabled = false;
        }

        void view_Start(object sender, EventArgs e)
        {
            model.timer.IsEnabled = true;
        }
    }

}
