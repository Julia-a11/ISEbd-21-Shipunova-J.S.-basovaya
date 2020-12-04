using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya
{
    // класс ошибка "Если в доках заняты уже все места"
    public class DocksOverflowException: Exception
    {
        public DocksOverflowException() : base ("В доках нет свободного места")
        { }
    }
}
