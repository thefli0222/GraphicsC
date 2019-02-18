using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Collections;

namespace GraphicsInterface
{
    static class Program
    {

        /*
        class Entities :
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
                return self.entityList

        class Entity :
            def __init__(self, intText):
                initValues = str.split(intText, "|")
                self.index = initValues[0]
                self.animal = initValues[1]
                sizeValues = str.split(initValues[2], ",")
                self.length = float(sizeValues[0])
                self.height = float(sizeValues[1])
                self.rot = 0
                self.posX = 0
                self.posY = 0

            def tickChange(self, string):
                changeValues = str.split(string, "|")
                posValues = str.split(changeValues[1], ",")
                if(changeValues[0] == self.index):
                    self.posX = float(posValues[0])
                    self.posY = float(posValues[1])
                    self.rot = float(changeValues[2])


        class ticks :
            def __init__(self, string):
                self.ticks = []
                for tickText in str.split(string, "T"):
                    if (tickText != ""):
                        self.ticks.append(tickText)

            def getTickInfo(self, tick) :
                return self.ticks[tick]

        class data :
            def __init__(self, string):
                self.generations = []
                for generationText in str.split(string, "\n"):
                    if (generationText != ""):
                        self.generations.append(ticks(generationText))

            def getTickInfo(self, gen, tick):
                return self.generations[gen].getTickInfo(tick)



        f = open("Output.txt", "r")

        text = str.split(f.read(), "B")

        entities = Entities(text[0])

        fullData = data(text[1])

        entitiesState = entities.getEntities()

        for x in range(0, 100):
            entities.updateWithTick(fullData.getTickInfo(0, x))
            entitiesState = entities.getEntities()
            print("PosX: " + str(entitiesState[0].posX) + " PosY: " + str(entitiesState[0].posY) + " Rot: " + str(entitiesState[0].rot))


        print(fullData.getTickInfo(0, 1))
        print(fullData.getTickInfo(0, 50))
        print(fullData.getTickInfo(0, 100))


        */


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
