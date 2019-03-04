using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;
using NumSharp.Core;
using System.Collections;

/*
def distanceToObject(radius, objPos, line1, line2):

    x = np.array(objPos)

    u = np.array(line1)
    v = np.array(line2)

    n = v - u
    n /= np.linalg.norm(n, 2)

    intersectPos = u + n* np.dot(x - u, n)

    distanceLineToObject = math.sqrt((intersectPos[0] - objPos[0])**2 + (intersectPos[1] - objPos[1])**2 )


    lineLength = math.sqrt((line1[0] - line2[0])**2 + (line1[1] - line2[1])**2 )
    distToline1 = math.sqrt((line1[0] - objPos[0])**2 + (line1[1] - objPos[1])**2 )
    distToline2 = math.sqrt((line2[0] - objPos[0])**2 + (line2[1] - objPos[1])**2 )

    if(distanceLineToObject <= radius):
        orginToIntersectDistance = math.sqrt((line1[0] - intersectPos[0])**2 + (line1[1] - intersectPos[1])**2 )

        if(orginToIntersectDistance<lineLength and distToline1 <= lineLength + radius and distToline2 <= lineLength + radius):
            return (orginToIntersectDistance)
        elif(distToline1 <= radius or distToline2 <= radius):
            return (orginToIntersectDistance)
        else:
            return (-1.0)

    else:
        return -1;

def createLines(nLines, lineLength, fieldOfView, startAngle, orgin):
    startX = orgin[0]
    startY = orgin[1]

    degreesPerLine = fieldOfView / (nLines-1)

    linesStartAtAngle = startAngle - fieldOfView/2;

    lines = [0 for x in range(nLines)]

    for lineIndex in range(nLines) :

        angle = linesStartAtAngle + lineIndex* degreesPerLine;

stopX = startX + math.sin(math.radians(angle) ) * lineLength
        stopY = startY + math.cos(math.radians(angle) ) * lineLength

        lines[lineIndex] = [(startX, startY),(stopX, stopY)]

    return lines

def line_intersection(line1, line2) :

    xdiff = (line1[0][0] - line1[1][0], line2[0][0] - line2[1][0])
    ydiff = (line1[0][1] - line1[1][1], line2[0][1] - line2[1][1])

    def det(a, b):
        return a[0] * b[1] - a[1] * b[0]

    div = det(xdiff, ydiff)
    if div == 0:
       return "none"

    d = (det(* line1), det(*line2))
    x = det(d, xdiff) / div
    y = det(d, ydiff) / div

    return x, y

def distanceFromWall(visionLine) :

    length = len(wallLines);

closestDistance = 1000000000;

    for lineIndex in range(len(wallLines)) :
        intersection = line_intersection((wallLines[lineIndex][0], wallLines[lineIndex][1]), (visionLine[0], visionLine[1]))

        if (intersection == "none"):
            return -1;
        else:
            xDeltaEnd = visionLine[1][0] - intersection[0]
            yDeltaEnd = visionLine[1][1] - intersection[1]

            distanceEnd = math.sqrt(xDeltaEnd**2 + yDeltaEnd**2 )


            if(distanceEnd <= visionLength):
                xDelta = visionLine[0][0] - intersection[0]
                yDelta = visionLine[0][1] - intersection[1]

                distance = math.sqrt(xDelta**2 + yDelta**2 )

                closestDistance = min(closestDistance, distance)

    return closestDistance;
    */


namespace GraphicsInterface
{
    class LineCalc
    {
        ArrayList wallLines;
        double visionLength;



        public static double distanceToObject(double radius, double[] objPos, double[] line1, double[] line2)
        {
            NDArray x = np.array(objPos);


            NDArray u = np.array(line1);
            NDArray v = np.array(line2);

            NDArray n = v - u;
            NDArray g = new NDArray(n);

            n /= 200;

            NDArray s = x - u;
            double dot = (double)s[0] * (double)n[0] + (double)s[1] * (double)n[1];
            NDArray intersectPos = u + n*dot;

            double distanceLineToObject = Math.Sqrt(Math.Pow(((double)intersectPos[0] - objPos[0]), 2) + Math.Pow(((double)intersectPos[1] - objPos[1]), 2));


            double lineLength = Math.Sqrt(Math.Pow((line1[0] - line2[0]), 2) + Math.Pow((line1[1] - line2[1]), 2));
            double distToline1 = Math.Sqrt(Math.Pow((line1[0] - objPos[0]), 2) + Math.Pow((line1[1] - objPos[1]), 2));
            double distToline2 = Math.Sqrt(Math.Pow((line2[0] - objPos[0]), 2) + Math.Pow((line2[1] - objPos[1]), 2));

            if (distanceLineToObject <= radius) {
                double orginToIntersectDistance = Math.Sqrt(Math.Pow((line1[0] - (double)intersectPos[0]), 2) + Math.Pow((line1[1] - (double)intersectPos[1]), 2));

                if (orginToIntersectDistance < lineLength && distToline1 <= lineLength + radius && distToline2 <= lineLength + radius) {
                    return (orginToIntersectDistance);
                }
                else if (distToline1 <= radius || distToline2 <= radius) {
                    return (orginToIntersectDistance);
                }
                else {
                    return (-1.0);
                }


            } else return -1;

        }

        public static ArrayList createLines(int nLines, double lineLength, double fieldOfView, double startAngle, double[] orgin) {
            double startX = orgin[0];
            double startY = orgin[1];

            double degreesPerLine = fieldOfView / (nLines - 1);

            double linesStartAtAngle = startAngle - fieldOfView / 2;


            ArrayList lines = new ArrayList();


            for (int lineIndex = 0; lineIndex < nLines; lineIndex++)
            {
                double angle = linesStartAtAngle + lineIndex * degreesPerLine;

                double stopX = startX + Math.Sin((Math.PI * angle / 180)) * lineLength;
                double stopY = startY + Math.Cos((Math.PI * angle / 180)) * lineLength;

                lines.Add(new LineData(startX, startY, stopX, stopY));
            }

            return lines;
        }


        public double distanceFromWall(LineData visionLine) {


            double closestDistance = 1000000000;

            for(int x = 0; x < 4; x++)
            {
                double[] intersection = visionLine.line_intersection((LineData)wallLines[x]);
                if (intersection == null)
                {
                    return -1;
                } else
                {
                    double xDeltaEnd = visionLine.EndX - intersection[0];
                    double yDeltaEnd = visionLine.EndY - intersection[1];

                    double distanceEnd = Math.Sqrt(Math.Pow(xDeltaEnd, 2) + Math.Pow(yDeltaEnd, 2));
                    if(distanceEnd <= visionLength)
                    {
                        double xDelta = visionLine.StartX - intersection[0];
                        double yDelta = visionLine.StartY - intersection[1];

                        double distance = Math.Sqrt(Math.Pow(xDeltaEnd, 2) + Math.Pow(yDeltaEnd, 2));
                        closestDistance = Math.Min(closestDistance, distance);
                    }
                }


            }
            return closestDistance;
        }
    }
}

