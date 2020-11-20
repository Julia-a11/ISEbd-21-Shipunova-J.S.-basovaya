using System.Collections.Generic;
using System.Linq;

namespace Laboratornaya
{
    public class DocksCollection
    {
        // Словарь (хранилище) с парковками
        readonly Dictionary<string, Docks<Ship>> docksStages;

        // Возвращение списка названий парковок
        public List<string> Keys => docksStages.Keys.ToList();

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисоки
        private readonly int pictureHeight;

        // Конструктор
        public DocksCollection(int pictureWidth, int pictureHeight)
        {
            docksStages = new Dictionary<string, Docks<Ship>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        // Добавление доков
        public void DocksAdd(string name)
        {
            if (docksStages.ContainsKey(name))
            {
                return;
            }
            docksStages.Add(name, new Docks<Ship>(pictureWidth, pictureHeight));
        }

        // Удаление доков
        public void DocksDel(string name)
        {
            if (docksStages.ContainsKey(name))
            {
                docksStages.Remove(name);
            }
        }

        // Доступ к докам
        public Docks<Ship> this[string ind]
        {
            get
            {
                if (docksStages.ContainsKey(ind))
                {
                    return docksStages[ind];
                }
                return null;
            }
        }
    }
}