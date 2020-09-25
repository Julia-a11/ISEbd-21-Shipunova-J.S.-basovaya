using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornaya
{
    public partial class FormWarShip : Form
    {
        private IWaterTransport warShip;
        public FormWarShip()
        {
            InitializeComponent();
        }

        // метод отрисовки гидросамолёта
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            warShip.DrawWaterTransport(gr);
            pictureBoxShip.Image = bmp;
        }

        // Обработка нажатия кнопки "Создать"
        private void buttonCreateAirctaft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warShip = new AircraftCarrier(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGray, Color.DimGray,true,true,true);
            warShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonCreateWarShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warShip = new WarShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGray);
            warShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        // Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            // получаем имя кнопки
            string name = (sender as Button).Name;
            switch(name)
            {
                case "buttonUp":
                    warShip.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    warShip.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    warShip.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    warShip.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
