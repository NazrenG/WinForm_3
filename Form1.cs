
using Task3.Properties;
namespace Task3
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        public bool check = true;
        private void button_baku_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resource1._4850343c57a40ed12748c1538a055d96;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 800;

            timer.Tick += Timer_Tick;
            timer.Start();
            check = true;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (check)
            {
                label1_watch.Text = DateTime.UtcNow.AddHours(4).ToLongTimeString();
            }
            else
            {
                label1_watch.Text = DateTime.UtcNow.AddHours(1).ToLongTimeString();
            }
        }

        private void button_london_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resource1.london;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 800;

            timer.Tick += Timer_Tick;
            timer.Start();
            check = false;

        }
    }
}