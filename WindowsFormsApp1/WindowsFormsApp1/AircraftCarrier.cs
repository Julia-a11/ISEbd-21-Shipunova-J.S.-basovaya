using System.Drawing;

namespace WindowsFormsApp1
{
    class AircraftCarrier
    {

        //левая координата отрисовки авианосца
        private float _startPosX;

        //правая координата отрисовки авианосца
        private float _startPosY;

        //ширина окна отрисовки
        private int _pictureWidth;

        //высота окна отрисовки
        private int _pictureHeight;

        // ширина отрисовки авианосца
        private readonly int aircraftCarrierWidth = 300;

        // высота отрисовки авианосца
        private readonly int aircraftCarrierHeight = 256;

        // максимальная скорость
        public int MaxSpeed { private set; get; }

        // вес
        public float Weight { private set; get; }

        // главный цвет
        public Color MainColor { private set; get; }

        // дополнительные цыета
        public Color DopColor { private set; get; }

        // наличие самолётов
        public bool HasPlane { private set; get; }

        // наличие взлётной полосы
        public bool HasRunWay { private set; get; }


        // наличие радара
        public bool HasRadar { private set; get; }





        // Конструктор
        public AircraftCarrier(int maxSpeed, float weight, Color mainColor, Color dopColor, bool hasPlane, bool hasRunWay, bool hasRadar)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            HasPlane = hasPlane;
            HasRunWay = hasRunWay;
            HasRadar = hasRadar;
        }


        // установка позиции авианосца
        public void SetPosition(int x, int y, int width, int height)
        {
            if ((_startPosX >= 0 && _startPosX + aircraftCarrierWidth < _pictureWidth) &&
                (_startPosY >= 0 && _startPosY + aircraftCarrierHeight < _pictureHeight))
            {
                _startPosX = x;
                _startPosY = y;
            }
            _pictureHeight = height;
            _pictureWidth = width;

        }


        // Изменение направления перемещения
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - aircraftCarrierWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                // влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                // вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                // вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - aircraftCarrierHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }

        }


        // отрисовка авианосца
        public void DrawAircraftCarrier(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), _startPosX + 15, _startPosY + 20, 275, 120);

            // отрисовка тела авианосца
            Point[] points = new Point[10]
                {
                   new Point((int)(_startPosX), (int)(_startPosY + 32)),
                   new Point((int)(_startPosX + 120), (int)(_startPosY )),
                   new Point((int)(_startPosX + 270), (int)(_startPosY)),
                   new Point((int)(_startPosX + 270), (int)(_startPosY + 32)),
                   new Point((int)(_startPosX + 300), (int)(_startPosY + 32)),
                   new Point((int)(_startPosX + 300), (int)(_startPosY + 128)),
                   new Point((int)(_startPosX + 270), (int)(_startPosY + 128)),
                   new Point((int)(_startPosX + 270), (int)(_startPosY + 160)),
                   new Point((int)(_startPosX + 120), (int)(_startPosY + 160)),
                   new Point((int)(_startPosX), (int)(_startPosY + 128)),
                };
            g.FillPolygon(new SolidBrush(MainColor), points);

            // отрисовка взлётной полосы
            if (HasRunWay)
            {

                points = new Point[4]
              {
                   new Point((int)(_startPosX + 70), (int)(_startPosY + 160)),
                   new Point((int)(_startPosX + 270), (int)(_startPosY + 32 )),
                   new Point((int)(_startPosX + 270), (int)(_startPosY + 128)),
                   new Point((int)(_startPosX + 70 ), (int)(_startPosY + 256)),

              };
                g.FillPolygon(new SolidBrush(DopColor), points);
            }

            // отрисовка радара
            if (HasRadar)
            {
                g.FillRectangle(new SolidBrush(Color.Black), _startPosX + 120, _startPosY + 10, 60, 30);
                g.FillEllipse(new SolidBrush(Color.LightGray), _startPosX + 130, _startPosY + 7, 20, 20);
            }


            // отрисовка самолёта
            if (HasPlane)
            {
                g.DrawLine(new Pen(Color.Black), _startPosX + 20, _startPosY + 80, _startPosX + 20, _startPosY + 112);
                g.DrawLine(new Pen(Color.Black), _startPosX + 20, _startPosY + 96, _startPosX + 60, _startPosY + 96);
                g.FillRectangle(new SolidBrush(Color.LightSlateGray), _startPosX + 35, _startPosY + 60, 15, 72);


            }

        }

    }


}
