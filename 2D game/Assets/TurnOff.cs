using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public float power=-50;
    void Start()
    {
        GetComponent<PointEffector2D>().forceMagnitude=0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GetComponent<PointEffector2D>().forceMagnitude = power;
        }
        else
        {
            GetComponent<PointEffector2D>().forceMagnitude = 0;
        }
    }
}
