using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornya
{
    // класс ошибка "Если не найден корабль по определённому месту"
    public class DocksNotFoundException : Exception
    {
        public DocksNotFoundException(int i) : base ("Не найден корабль по месту " + i)
        { }
    }
}
