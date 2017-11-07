using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameObjectsLab2
{
    public class GameFactory
    {
        List<Game> GameList;
        StreamWriter jayWriter;
        XmlSerializer jaySerial;

        public string FilePath { get; set; }

        public void CreateGameList()
        {
            GameList = new List<Game>();

            GameList.Add(new Game("Dolphins", 30, "Patriots", 12));
            GameList.Add(new Game("RedSkins", 22, "Steelers", 40));
            GameList.Add(new Game("CowBoys", 50, "Packers", 84));
            GameList.Add(new Game("Eagles", 100, "Saints", 34));
            GameList.Add(new Game("Jets", 56, "Oakland", 15));
            GameList.Add(new Game("Broncos", 60, "Falcons", 38));

        }


        public Boolean SerializeGameList()
        {
            try
            {
                jaySerial = new XmlSerializer(GameList.GetType());
                jayWriter = new StreamWriter(@"..\..\game.xml");
                jaySerial.Serialize(jayWriter, GameList);
                jayWriter.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}