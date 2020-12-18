using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Laboratornaya
{
    // Параметризованный класс для хранения набора объектов от интерфейса IWaterTrnsport
    public class Docks<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, IWaterTransport
    {
        //Список объектов, которые храним
        private readonly List<T> _places;

        //Максимальное количество мест в доках
        private readonly int _maxDocksPlaces;
        
        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 210;

        // Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 130;

        // Текущий элемент для вывода через IEnumerator (будет обращаться по своему
        //индексу к ключу словаря, по которму будет возвращаться запись)
        private int _currentIndex;

        public T Current => _places[_currentIndex];

        object IEnumerator.Current => _places[_currentIndex];

        public Docks(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxDocksPlaces = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }

        //Перегрузка оператора сложения
        public static bool operator +(Docks<T> d, T ship)
        {
            if (d._places.Count >= d._maxDocksPlaces)
            {
                throw new DocksOverflowException();
            }
            if (d._places.Contains(ship))
            {
                throw new DocksAlreadyHaveException();
            }
            d._places.Add(ship);
            return true;
        }

        // Перегрузка оператора вычитания
        public static T operator -(Docks<T> d, int index)
        {
            if (index < 0 || index >= d._places.Count)
            {
                throw new DocksNotFoundException(index);
            }
            T ship = d._places[index];
            d._places.RemoveAt(index);
            return ship;
        }

        // Метод отрисовки дока
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(_placeSizeWidth * ( i / (pictureHeight / _placeSizeHeight)),
                       20 + _placeSizeHeight * (i % (pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
                _places[i].DrawWaterTransport(g);
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

        // функция получения элемента из списка
        public T GetNext(int ind)
        {
            if (ind < 0 || ind >= _places.Count)
            {
                return null;
            }
            return _places[ind];
        }

        // сортировка кораблей в доках
        public void Sort() => _places.Sort((IComparer<T>) new WarShipComparer());

        // метод интерфейса IEnumerator, вызываемый при удалении объекта
        public void Dispose()
        {
        }

        // Метод интерфейса IEnumerator для перехода к следующему элементу или началу
        //коллекции
        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _places.Count;
        }

        //  Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        public void Reset()
        {
            _currentIndex = -1;
        }

        // Метод интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        // Метод интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}