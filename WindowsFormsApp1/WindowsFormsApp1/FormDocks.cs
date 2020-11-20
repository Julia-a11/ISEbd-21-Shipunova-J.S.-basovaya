using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratornaya
{
    public partial class FormDocks : Form
    {
        //объект от класса - коллекции доков
        private readonly DocksCollection docksCollection;

        public FormDocks()
        {
            InitializeComponent();
            docksCollection = new DocksCollection(pictureBoxDocks.Width, pictureBoxDocks.Height);
        }

        // Заполнение listBox
        private void ReloadLevels()
        {
            int index = listBoxDocks.SelectedIndex;
            listBoxDocks.Items.Clear();
            for (int i = 0; i < docksCollection.Keys.Count; i++)
            {
                listBoxDocks.Items.Add(docksCollection.Keys[i]);
            }
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >= listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;
            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index < listBoxDocks.Items.Count)
            {
                listBoxDocks.SelectedIndex = index;
            }
        }

        //метод отрисовки дока
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDocks.Width, pictureBoxDocks.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxDocks.SelectedIndex > -1)
            {
                docksCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
            }
            else
            {
                gr.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, pictureBoxDocks.Width, pictureBoxDocks.Height);
            }
            pictureBoxDocks.Image = bmp;
        }

        //обработка нажатия кнопки "Припарковать военный корабль"
        private void buttonParkingWarShip_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new WarShip(100, 1000, dialog.Color);
                    if (docksCollection[listBoxDocks.SelectedItem.ToString()] + ship)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Доки переполнены");
                    }
                }
            }
        }

        //обработка нажатия кнопки "Припарковать авианосец"
        private void buttonParkingAircraftCarrier_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new AircraftCarrier(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (docksCollection[listBoxDocks.SelectedItem.ToString()] + ship)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Доки переполнены");
                        }
                    }
                }
            }
        }

        //обработка кнопки "Забрать"
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text != "" && listBoxDocks.SelectedIndex > -1)
            {
                var ship = docksCollection[listBoxDocks.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxNumber.Text);
                if (ship != null)
                {
                    FormWaterTransport form = new FormWaterTransport();
                    form.SetShip(ship);

                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonAddDocks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDocks.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            docksCollection.DocksAdd(textBoxDocks.Text);
            ReloadLevels();
        }

        private void buttonDocksRemove_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док {listBoxDocks.SelectedItem.ToString()}?",
                   "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    docksCollection.DocksDel(listBoxDocks.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }    
    }
}