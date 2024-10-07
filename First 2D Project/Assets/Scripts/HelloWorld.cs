using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "Timmy";
        Debug.Log(name);
        int health = 10;
        Debug.Log("Health = " + health);
        float critChance = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
    }
}
