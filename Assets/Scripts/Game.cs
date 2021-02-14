using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject myPrefab;
    public int weight = 10, height = 10;

    static List<Figure> figures = new List<Figure>();



    void Start()
    {
        Instantiate(myPrefab);
        // Устанавливаем метод обратного вызова
        //TimerCallback timerCallback = new TimerCallback(GenerateFigure);

        // Создаем таймер
        //Timer timer = new Timer(timerCallback, null, 0, 5000);
    }

    public void GenerateFigure()
    {
        Instantiate(myPrefab);
        //Figure figure = new Figure();
        //figures.Add(figure);
    }
}
