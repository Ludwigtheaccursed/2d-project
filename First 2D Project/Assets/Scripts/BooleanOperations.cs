using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool tf1 = true;
        bool tf2 = false;
        bool tf3 = true;
        if (tf1 && tf2 || tf3)
        {
            //do something
        }
        bool cakeMix = true;
        bool eggs = true;
        bool flour = true;
        bool sugar = true;
        bool money = true;
        if (cakeMix || eggs && flour && sugar || money)
        {
            //I get cake
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
