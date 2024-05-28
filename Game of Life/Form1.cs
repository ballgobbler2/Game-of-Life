using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        bool STARTED = false;
        bool[,] GRID = new bool[30, 30];
        bool[,] GRIDNEXT = new bool[30, 30];
        Point CURSOR;
        public Form1()
        {
            InitializeComponent();

        }

        private void START_STOP_Click(object sender, EventArgs e)
        {
            if (STARTED)
            {
                START_STOP.Text = "START";
                STARTED = false;
                timer1.Enabled = false;
                for (int y = 0; y < 30; y++)
                {
                    for (int x = 0; x < 30; x++)
                    {
                        GRIDNEXT[y, x] = false;
                    }
                }
            }
            else
            {
                string delay = textBox1.Text;
                START_STOP.Text = "STOP";
                STARTED = true;
                timer1.Interval = Convert.ToInt32(delay);
                timer1.Enabled = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush bruh = new SolidBrush(Color.Black);
            Brush china = new SolidBrush(Color.Yellow);
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    if (GRID[x, y])
                    {
                        g.FillRectangle(china, new Rectangle(x * 20, y * 20, 20, 20));
                    }
                    else
                    {
                        g.FillRectangle(bruh, new Rectangle(x * 20, y * 20, 20, 20));
                    }

                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            CURSOR = panel1.PointToClient(Cursor.Position);
            if (e.Button == MouseButtons.Left) { GRID[CURSOR.X / 20, CURSOR.Y / 20] = true; }
            else if (e.Button == MouseButtons.Right) { GRID[CURSOR.X / 20, CURSOR.Y / 20] = false; }
            panel1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    int count = 0;
                    if (x != 0 && y != 0)
                    {
                        if (GRID[x - 1, y - 1])
                            count++;
                    }
                    else
                    {
                        if (x != 0)
                        {
                            if (GRID[x - 1, 29])
                                count++;
                        }
                        if (y != 0)
                        {
                            if (GRID[29, y - 1])
                                count++;
                        }
                        if (x == 0 && y == 0)
                        {
                            if (GRID[29, 29])
                                count++;
                        }
                    }


                    if (y != 0)
                    {
                        if (GRID[x, y - 1])
                            count++;
                    }
                    else
                    {
                        if (GRID[x, 29])
                            count++;
                    }

                    if (x != 29 && y != 0)
                    {
                        if (GRID[x + 1, y - 1])
                            count++;
                    }
                    else
                    {
                        if (x != 29)
                        {
                            if (GRID[x + 1, 29])
                                count++;
                        }
                        if (y != 0)
                        {
                            if (GRID[0, y - 1])
                                count++;
                        }
                        if (x == 29 && y == 0)
                        {
                            if (GRID[0, 29])
                                count++;
                        }
                    }



                    if (x != 0)
                    {
                        if (GRID[x - 1, y])
                            count++;
                    }
                    else
                    {
                        if (GRID[29, y])
                            count++;
                    }

                    if (x != 29)
                    {
                        if (GRID[x + 1, y])
                            count++;
                    }
                    else
                    {
                        if (GRID[0, y])
                            count++;
                    }

                    if (x != 0 && y != 29)
                    {
                        if (GRID[x - 1, y + 1])
                            count++;
                    }
                    else
                    {
                        if (x != 0)
                        {
                            if (GRID[x - 1, 0])
                                count++;
                        }
                        if (y != 29)
                        {
                            if (GRID[29, y + 1])
                                count++;
                        }
                        if (x == 0 && y == 29)
                        {
                            if (GRID[29, 0])
                                count++;
                        }
                    }



                    if (y != 29)
                    {
                        if (GRID[x, y + 1])
                            count++;
                    }
                    else
                    {
                        if (GRID[x, 0])
                            count++;
                    }

                    if (x != 29 && y != 29)
                    {
                        if (GRID[x + 1, y + 1])
                            count++;
                    }
                    else
                    {
                        if (x != 29)
                        {
                            if (GRID[x + 1, 0])
                                count++;
                        }
                        if (y != 29)
                        {
                            if (GRID[0, y + 1])
                                count++;
                        }
                        if (x == 29 && y == 29)
                        {
                            if (GRID[0, 0])
                                count++;
                        }
                    }

                    if (GRID[x, y])
                    {
                        if (count < 2)
                            GRIDNEXT[x, y] = false;
                        if (2 <= count && count <= 3)
                            GRIDNEXT[x, y] = true;
                        if (count > 3)
                            GRIDNEXT[x, y] = false;
                    }
                    else
                    {
                        if (count == 3)
                            GRIDNEXT[x, y] = true;
                    }
                }
            }
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    GRID[x, y] = GRIDNEXT[x, y];
                }
            }
            panel1.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            START_STOP.Text = "START";
            STARTED = false;
            timer1.Enabled = false;
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    GRIDNEXT[y, x] = false;
                    GRID[y, x] = false;
                }
            }
            panel1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

    }
}