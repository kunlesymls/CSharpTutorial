using System;
using System.Windows.Forms;

namespace TimeFoms
{
    public partial class Form1 : Form
    {
        private DateTime startedAt;
        private DateTime endAt;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer ShowElapsedTime = new Timer();
            ShowElapsedTime.Interval = 1000;     // 10 seconds
            ShowElapsedTime.Tick += ShowElapsedTime_Tick;
            ShowElapsedTime.Start();
            startedAt = DateTime.Now;
        }

        void ShowElapsedTime_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now - startedAt;

            string min = diff.Minutes.ToString().Length == 1 ? $"0{diff.Minutes.ToString("")}" : diff.Minutes.ToString("");
            string sec = diff.Seconds.ToString().Length == 1 ? $"0{diff.Seconds.ToString("")}" : diff.Seconds.ToString("");
            lbt_time.Text = $"{ diff.Hours.ToString()}:{ min}:{ sec}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer ShowElapsedTime = new Timer();
            ShowElapsedTime.Interval = 1000;     // 10 seconds
            ShowElapsedTime.Tick += ShowCountTime_Tick;
            ShowElapsedTime.Start();
            startedAt = DateTime.Now;
            endAt = startedAt.AddMinutes(1);
        }

        void ShowCountTime_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = endAt - DateTime.Now;

            string min = diff.Minutes.ToString().Length == 1 ? $"0{diff.Minutes.ToString("")}" : diff.Minutes.ToString("");
            string sec = diff.Seconds.ToString().Length == 1 ? $"0{diff.Seconds.ToString("")}" : diff.Seconds.ToString("");
            lbt_time.Text = $"{ diff.Hours.ToString()}:{ min}:{ sec}";

        }
    }
}
