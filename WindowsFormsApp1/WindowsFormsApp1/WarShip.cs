using System.Drawing;

namespace Laboratornaya
{
    //базовый класс
    public class WarShip : Ship
    {
        // ширина отрисовки корабля
        protected readonly int shipWidth = 150;

        // высота отрисовки корабля
        protected readonly int shipHeight = 100;

        //конструктор
        public WarShip(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        //конструктор с изменением размеров корабля
        protected WarShip(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
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
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawWaterTransport(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), _startPosX + 5, _startPosY + 10, 140, 80);

            // отрисовка тела корабля
            Point[] points = new Point[10]
            {
                   new Point((int)(_startPosX ), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 40), (int)(_startPosY )),
                   new Point((int)(_startPosX + 120), (int)(_startPosY)),
                   new Point((int)(_startPosX + 120), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 150), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 150), (int)(_startPosY + 78)),
                   new Point((int)(_startPosX + 120), (int)(_startPosY + 78)),
                   new Point((int)(_startPosX + 120), (int)(_startPosY + 100)),
                   new Point((int)(_startPosX + 40), (int)(_startPosY + 100)),
                   new Point((int)(_startPosX ), (int)(_startPosY + 78)),
            };
            g.FillPolygon(new SolidBrush(MainColor), points);

            //отрисовка запасной лодки
            Point[] points1 = new Point[12]
            {
                   new Point((int)(_startPosX + 30), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 65), (int)(_startPosY  + 22)),
                   new Point((int)(_startPosX + 65), (int)(_startPosY + 17)),
                   new Point((int)(_startPosX + 85), (int)(_startPosY + 17)),
                   new Point((int)(_startPosX + 85), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 110), (int)(_startPosY + 22)),
                   new Point((int)(_startPosX + 110), (int)(_startPosY + 78)),
                   new Point((int)(_startPosX + 85), (int)(_startPosY + 78)),
                   new Point((int)(_startPosX + 85), (int)(_startPosY + 83)),
                   new Point((int)(_startPosX + 65), (int)(_startPosY + 83)),
                   new Point((int)(_startPosX + 65), (int)(_startPosY + 78)),
                   new Point((int)(_startPosX + 30), (int)(_startPosY + 78)),
            };
            g.FillPolygon(new SolidBrush(Color.Gray), points1);
            g.FillEllipse(new SolidBrush(Color.Brown), _startPosX + 35, _startPosY + 40, 70, 20);

            //отрисовка оружия
            g.FillRectangle(new SolidBrush(Color.Gray), _startPosX + 122, _startPosY + 35, 25, 25);
            g.FillEllipse(new SolidBrush(Color.Green), _startPosX + 127, _startPosY + 40, 15, 15);
            g.DrawLine(new Pen(Color.Black), _startPosX + 139, _startPosY + 47, _startPosX + 149, _startPosY + 47);
        }
    }
}