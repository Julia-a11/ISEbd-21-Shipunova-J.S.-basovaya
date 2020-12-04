using System;

namespace Laboratornaya
{
    // класс ошибка "Если не найден корабль по определённому месту"
    public class DocksNotFoundException : Exception
    {
        public DocksNotFoundException(int i) : base ("Не найден корабль по месту " + i)
        { }
    }
}