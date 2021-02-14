using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject myPrefab;
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    // Start is called before the first frame update
    void Start()
    {
        int zz = Main.random.Next(1,5);
        //Instantiate(myPrefab, new Vector3(zz, zz, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
