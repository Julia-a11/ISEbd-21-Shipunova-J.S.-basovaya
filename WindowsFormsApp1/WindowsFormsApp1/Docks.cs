using System.Drawing;

namespace Laboratornaya
{
    // Параметризованный класс для хранения набора объектов от интерфейса IWaterTrnsport
    public class Docks<T> where T : class, IWaterTransport
    {
        //Массив хранимых объектов
        private readonly T[] _places;

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 210;

        // Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 130;

        public Docks(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        //Перегрузка оператора сложения
        public static bool operator +(Docks<T> d, T ship)
        {
            for (int i = 0; i < d._places.Length; i++)
            {
                if (d._places[i] == null)
                {
                    d._places[i] = ship;
                    d._places[i].SetPosition( d._placeSizeWidth * (i / (d.pictureHeight / d._placeSizeHeight)), 
                        15 + d._placeSizeHeight * (i % (d.pictureHeight / d._placeSizeHeight)), d.pictureWidth, d.pictureHeight);
                    return true;
                }
            }
            return false;
        }

        // Перегрузка оператора вычитания
        public static T operator -(Docks<T> d, int index)
        {
            if (index >= 0 && index < d._places.Length)
            {
                T ship = d._places[index];
                d._places[index] = null;
                return ship;
            }
            return null;
        }

        // Метод отрисовки дока
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawWaterTransport(g);
            }
        }

        //метод отрисовки мест
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    //линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                        i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                    (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
