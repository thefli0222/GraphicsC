using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*class data :
            def __init__(self, string):
                self.generations = []
                for generationText in str.split(string, "\n"):
                    if (generationText != ""):
                        self.generations.append(ticks(generationText))

            def getTickInfo(self, gen, tick):
                return self.generations[gen].getTickInfo(tick)*/


namespace GraphicsInterface
{
    class Data
    {
        private ArrayList generations;
        public Data(String data)
        {
            generations = new ArrayList();
            foreach (string generationText in data.Split('\n'))
            {
                if (generationText != "")
                {
                    generations.Add(new Ticks(generationText));
                }
            }
        }

        public string getTickInfo(int gen, int tick)
        {
            return (string)((Ticks)generations[gen]).getTickInfo(tick);
        }
    }
}
