using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    public GameObject pfbPoint;
    int x, y;
    int width, height;
    List<Point> points = new List<Point>();

    string color;


    // Start is called before the first frame update
    void Start()
    {
        width = Main.random.Next(1, 5);
        height = Main.random.Next(1, 5);
        //x = Main.random.Next(1, GameObject.Find("Game").GetComponent<Game>().weight - width);
        //y = Main.random.Next(1, GameObject.Find("Game").GetComponent<Game>().height - height);
        x = 10;
        y = 10;

        int figurePointsCount = width * height * Main.random.Next(50, 71) / 100;
        if (figurePointsCount < 1) { figurePointsCount = 1; }
        if (figurePointsCount > width * height) { figurePointsCount = width * height; }
        List<int[]> figurePoints = new List<int[]>();
        while (figurePoints.Count < figurePointsCount)
        {
            int figureX = Main.random.Next(1, width + 1);
            int figureY = Main.random.Next(1, height + 1);
            int[] point = new int[2] { figureX, figureY };
            bool flag = true;
            if (figurePoints != null && figurePoints.Count > 0)
            {
                foreach (var item in figurePoints)
                {
                    if (item[0] == figureX && item[1] == figureY)
                    {
                        flag = false;
                        break;
                    }
                    flag = true;
                    continue;
                }
            }
            
            if (flag) {
                figurePoints.Add(point);

                //Point point2 = new Point(x, y);
                //points.Add(point2);
                //gameObject.AddComponent<Point>();
                GameObject currentPoint = Instantiate(pfbPoint);
                currentPoint.transform.position = new Vector3(figureX, figureY, 0);
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
