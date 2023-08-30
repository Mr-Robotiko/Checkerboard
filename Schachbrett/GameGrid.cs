namespace Schachbrett
{
    public partial class GameGrid : Form
    {
        public GameGrid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += PrintForm;
            Size dimension = new Size(800, 800);
            this.ClientSize = dimension;
            ResizeRedraw = true;
            BackColor = Color.Tomato;

        }

        private void PrintForm(object sender, PaintEventArgs eventum)
        {
            Graphics graphic = eventum.Graphics;
            int width = this.ClientSize.Width;
            int heigth = this.ClientSize.Height;



            Brush brushBlack = new SolidBrush(Color.Black);
            Brush brushWhite = new SolidBrush(Color.White);



            for (int y = 0; y < heigth / 100; y++)
            {
                for (int i = 0; i < width / 100; i++)
                {
                    int index = y + i;

                    Rectangle whiteRectangle = new Rectangle(i * width / 8, y * heigth / 8, width / 8, heigth / 8);
                    if (index % 2 == 0)
                    {
                        graphic.FillRectangle(brushBlack, whiteRectangle);
                    }
                    else
                    {
                        graphic.FillRectangle(brushWhite, whiteRectangle);
                    }
                }
            }
        }
    }
}

