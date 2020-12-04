using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

        // разделитель для записи информации в файл
        private readonly char separator = ':';

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

        // сохранение информации по кораблям в доках в файл
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine($"DocksCollection");
                foreach (var level in docksStages)
                {
                    // начинаем парковку
                    sw.WriteLine($"Docks{separator}{level.Key}");
                    IWaterTransport ship = null;
                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            // если место не пустое
                            // записываем тип корабля
                            if (ship.GetType().Name == "WarShip")
                            {
                                sw.Write($"WarShip {separator}");
                            }
                            if (ship.GetType().Name == "AircraftCarrier")
                            {
                                sw.Write($"AircraftCarrier{separator}");
                            }
                            // записываем параметры
                            sw.WriteLine(ship);
                        }
                    }
                }
            }
        }

        // загрузка информации по кораблям в доках из файла
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                string line = sr.ReadLine();
                if (line.Contains("DocksCollection"))
                {
                    docksStages.Clear();
                }
                else
                {
                    throw new FileLoadException();
                }
                string key = string.Empty;
                WarShip warShip = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Dock"))
                    {
                        key = line.Split(separator)[1];
                        docksStages.Add(key, new Docks<Ship>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {                      
                        if (line.Contains("WarShip"))
                        {
                            warShip = new WarShip(line.Split(separator)[1]);
                        }
                        else if (line.Contains("AircraftCarrier"))
                        {
                            warShip = new AircraftCarrier(line.Split(separator)[1]);
                        }
                        if (!(docksStages[key] + warShip))
                        {
                            throw new DocksOverflowException();
                        }
                    }
                }
            }          
        }
    }
}