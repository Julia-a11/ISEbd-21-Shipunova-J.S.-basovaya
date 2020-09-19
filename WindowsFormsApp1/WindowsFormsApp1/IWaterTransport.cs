using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
