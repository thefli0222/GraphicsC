using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*class ticks :
    def __init__(self, string):

        self.ticks = []
                for tickText in str.split(string, "T"):
                    if (tickText != ""):
                        self.ticks.append(tickText)

            def getTickInfo(self, tick) :
                return self.ticks[tick]*/

namespace GraphicsInterface
{
    class Ticks
    {
        private ArrayList tick;
        public Ticks(string tickData)
        {
            tick = new ArrayList();

            foreach(string tickText in tickData.Split('T'))
            {
                if(tickText != "")
                {
                    tick.Add(tickText);
                }
            }
        }

        public string getTickInfo(int tickNum)
        {
            return (string)tick[tickNum];
        }
    }
}
