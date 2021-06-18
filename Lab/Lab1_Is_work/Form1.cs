using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Is_work
{
    public partial class Lab1 : Form
    {

        public Lab1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
        }

      
        //движение 
        private void OKP(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString()); // проверка клавиш

            switch(e.KeyCode.ToString())
            {

                case "Right": // в право

                    cube.Location = new Point(cube.Location.X + 5, cube.Location.Y);
                    if (cube.Right >= this.ClientSize.Height)
                    {
                        cube.Location = new Point(cube.Location.X - 5, cube.Location.Y);
                    }

                    //cube.Location = new Point(cube.Location.X + 5, cube.Location.Y);
                    break;

                case "Left":
                    cube.Location = new Point(cube.Location.X - 5, cube.Location.Y);
                    if (cube.Left <= 0)
                    {
                        cube.Location = new Point(cube.Location.X + 5, cube.Location.Y);
                    }
                    break;

                case "Up":

                    cube.Location = new Point(cube.Location.X, cube.Location.Y - 5);
                    if (cube.Bottom <= 0)
                    {
                        cube.Location = new Point(cube.Location.X, cube.Location.Y + 5);
                    }
                    break;

                case "Down":

                    cube.Location = new Point(cube.Location.X, cube.Location.Y + 5);
                    if (cube.Top >= this.ClientSize.Width)
                    {
                        cube.Location = new Point(cube.Location.X, cube.Location.Y - 5);
                    }
                    break;
            }
        }
    }
}
