using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratornaya
{
    public partial class FormWaterTransport : Form
    {
        private IWaterTransport ship;
        public FormWaterTransport()
        {
            InitializeComponent();
        }

        // Передача корабля на форму
        public void SetShip(IWaterTransport ship)
        {
            this.ship = ship;
            Draw();
        }

        // метод отрисовки гидросамолёта
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxWaterTransport.Width, pictureBoxWaterTransport.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship?.DrawWaterTransport(gr);
            pictureBoxWaterTransport.Image = bmp;
        }

        // Обработка нажатия кнопки "Создать"
        private void buttonCreateAirctaft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new AircraftCarrier(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGray, Color.DimGray, true, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxWaterTransport.Width, pictureBoxWaterTransport.Height);
            Draw();
        }

        private void buttonCreateWarShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new WarShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGray);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxWaterTransport.Width, pictureBoxWaterTransport.Height);
            Draw();
        }

        // Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            // получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }      
    }
}