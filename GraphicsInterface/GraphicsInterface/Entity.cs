using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*class Entity :
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
                    self.posX = float (posValues[0])
                     self.posY = float(posValues[1])
                     self.rot = float(changeValues[2])*/


namespace GraphicsInterface
{
    class Entity
    {
        private int index;
        private int animal;
        private int length;
        private int height;
        private float posX;
        private float posY;
        private float rot;

        public Entity (String initInfo)
        {
            string[] tempVal = initInfo.Split('|');
            Index = int.Parse(tempVal[0]);
            Animal = int.Parse(tempVal[1]);
            string[] tempSize = tempVal[2].Split(',');
            Length = int.Parse(tempSize[0]);
            Height = int.Parse(tempSize[1]);
            PosX = 0;
            PosY = 0;
            Rot = 0;
        }

        public int Length { get => length; set => length = value; }
        public int Height { get => height; set => height = value; }
        public float PosX { get => posX; set => posX = value; }
        public float PosY { get => posY; set => posY = value; }
        public float Rot { get => rot; set => rot = value; }
        public int Animal { get => animal; set => animal = value; }
        public int Index { get => index; set => index = value; }

        public void tickChange(string tickData)
        {
            string[] changeValues = tickData.Split('|');
            string[] posValues = changeValues[1].Split(',');
            if(int.Parse(changeValues[0]) == Index)
            {
                //posValues[0] = posValues[0].Replace('.', ',');
                //posValues[1] = posValues[1].Replace('.', ',');
                //changeValues[2] = changeValues[2].Replace('.', ',');

                PosX = float.Parse(posValues[0]);
                PosY = float.Parse(posValues[1]);
                Rot = float.Parse(changeValues[2]);
            }
        }
        
    }
}
