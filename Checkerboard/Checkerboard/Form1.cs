using System;
using System.Drawing;
using System.Windows.Forms;

namespace Checkerboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The first method

            /*
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Button button = new Button();

                    button.Width = 50;
                    button.Height = 50;

                    button.Left = j * 50; 
                    button.Top = i * 50;  

                    this.Controls.Add(button);
                }

            }
            */

            //The second method

            Button[,] buttons = new Button[8, 8];

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();

                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;

                    buttons[i, j].Left = j * 50; // x position
                    buttons[i, j].Top = i * 50;  // y position


                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);
                }
            }



        }
    }
}
