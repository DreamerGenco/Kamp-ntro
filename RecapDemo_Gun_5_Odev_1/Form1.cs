namespace RecapDemo_Gun_5_Odev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8,8];
            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i,j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    this.Controls.Add(button[i, j]);

                }
            }
             

                

        }
    }
}