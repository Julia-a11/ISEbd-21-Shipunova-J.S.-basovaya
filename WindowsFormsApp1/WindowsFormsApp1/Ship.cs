using System.Drawing;

namespace Laboratornaya
{
    //абстрактный класс
    public abstract class Ship: IWaterTransport
    {
        //левая координата отрисовки корабля
        protected float _startPosX;

        //правая координата отрисовки корабля
        protected float _startPosY;

        //ширина окна отрисовки
        protected int _pictureWidth;

        //высота окна отрисовки
        protected int _pictureHeight;

        // максимальная скорость
        public int MaxSpeed { protected set; get; }

        // вес
        public float Weight { protected set; get; }

        // главный цвет
        public Color MainColor { protected set; get; }

        //установка позиции авианосца
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureHeight = height;
            _pictureWidth = width;

            if ((_startPosX >= 0 && _startPosX   < _pictureWidth) &&
                (_startPosY >= 0 && _startPosY   < _pictureHeight))
            {
                _startPosX = x;
                _startPosY = y;
            }            
        }

        public void SetMainColor (Color color)
        {
            MainColor = color;
        }

        public abstract void DrawWaterTransport(Graphics g);

        public abstract void MoveTransport(Direction direction); 
    }
}
