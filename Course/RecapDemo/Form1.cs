namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButton();
        }

        private void GenerateButton()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button
                    {
                        Width = 50,
                        Height = 50,
                        Left = left,
                        Top = top,
                    };
                    left += 50;

                    if ((i + j) % 2 == 0) buttons[i, j].BackColor = Color.Black;
                    else buttons[i, j].BackColor = Color.White;

                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
