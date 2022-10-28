namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int delta_x = 5;
        int delta_y = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while(button1.Location.X < 150 && button1.Location.Y < 150 ){
                button1.Location = new Point(button1.Location.X + delta_x, button1.Location.Y + delta_y);
            }
        }
    }
}