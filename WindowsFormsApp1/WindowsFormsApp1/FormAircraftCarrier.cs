using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAircraftCarrier : Form
    {

        private AircraftCarrier aircraft;
        public FormAircraftCarrier()
        {
            InitializeComponent();
        }

        // метод отрисовки гидросамолёта
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraftCarrier.Width, pictureBoxAircraftCarrier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawAircraftCarrier(gr);
            pictureBoxAircraftCarrier.Image = bmp;
        }

        
       

        // Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new AircraftCarrier(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGray,
                Color.DimGray, true, true, true);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraftCarrier.Width, pictureBoxAircraftCarrier.Height);
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
                    aircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        
    }
}
