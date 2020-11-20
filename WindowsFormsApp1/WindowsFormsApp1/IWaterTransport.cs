using System.Drawing;

namespace Laboratornaya
{
    //интерфейс 
    public interface IWaterTransport
    {
        //установка позиции
         void SetPosition(int x, int y, int width, int height);

        //изменение направления перемещения
        void MoveTransport(Direction direction);

        //отрисовка
        void DrawWaterTransport(Graphics g);
    }
}