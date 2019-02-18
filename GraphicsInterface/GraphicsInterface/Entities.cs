using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*class Entities :
            def __init__(self, intText):
                self.entityList = []
                for infoText in str.split(intText, "O"):
                    if (infoText != ""):
                        self.entityList.append(Entity(infoText))


            def updateWithTick(self, string):
                var = 0
                for infoText in str.split(string, "O"):
                    if (infoText != ""):
                        self.entityList[var].tickChange(infoText)
                    var += 1

            def getEntities(self):
                return self.entityList */

namespace GraphicsInterface
{
    class Entities
    {
        private ArrayList entity;

        public Entities(String initInfo)
        {
            string[] tempEntityString = initInfo.Split('O');
            entity = new ArrayList();
            foreach(string entityString in tempEntityString)
            {
                if(entityString != "")
                {
                    entity.Add(new Entity(entityString));
                }
            }
        }

        public void updateWithTick(string tickData)
        {
            int var = 0;
            foreach(string infoText in tickData.Split('O'))
            {
                if(infoText != "")
                {
                    ((Entity)entity[var]).tickChange(infoText);
                }
                var++;
            }
        }

        public ArrayList getEntities()
        {
            return entity;
        }
    }
}
