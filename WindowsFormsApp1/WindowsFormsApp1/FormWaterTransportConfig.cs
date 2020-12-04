using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratornaya
{
    public partial class FormWaterTransportConfig : Form
    {
        // Переменная-выбранное военное судно
        private Ship ship = null;

        private Action<Ship> eventAddWarShip;
        public FormWaterTransportConfig()
        {
            InitializeComponent();
            panelBlackColor.MouseDown += panelColor_MouseDown;
            panelOrangeColor.MouseDown += panelColor_MouseDown;
            panelPurpleColor.MouseDown += panelColor_MouseDown;
            panelYellowColor.MouseDown += panelColor_MouseDown;
            panelGreenColor.MouseDown += panelColor_MouseDown;
            panelBlueColor.MouseDown += panelColor_MouseDown;
            panelRedColor.MouseDown += panelColor_MouseDown;
            panelCoralColor.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                ship.DrawWaterTransport(gr);
                pictureBoxDisplay.Image = bmp;
            }
        }

        //Добавляем событие 
        public void AddEvent(Action<Ship> ev)
        {
            if (eventAddWarShip == null)
            {
                eventAddWarShip = new Action<Ship>(ev);
            }
            else
            {
                eventAddWarShip += ev;
            }
        }

        // Передаём информацию при нажатии на Label
        private void labelWarShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelWarShip.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        // Передаём информацию при нажатии на Label
        private void labelAircraftCarrier_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraftCarrier.DoDragDrop(labelAircraftCarrier.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        // Проверка получаемой информации (её типа на соответствие требуемому)
        private void panelDisplay_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Действие при приёме перетаскиваемой информации
        private void panelDisplay_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный корабль":
                    ship = new WarShip((int)numericUpDownMaxSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Авианосец":
                    ship = new AircraftCarrier((int)numericUpDownMaxSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxPlane.Checked, checkBoxRunway.Checked, checkBoxRadar.Checked);
                    break;
            }
            DrawShip();
        }

        // Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Control panelColor = (Control)sender;
            panelColor.DoDragDrop(panelColor.BackColor, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        // Проверка получаемой информации (её типа на соответствие требуемому)
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Принимаем основной цвет
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        // Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is AircraftCarrier)
            {
                AircraftCarrier aircraftCarrier = (AircraftCarrier)ship;
                aircraftCarrier.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        // Добавление корабля
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddWarShip?.Invoke(ship);
            Close();
        }
    }
}