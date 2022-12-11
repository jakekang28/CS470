using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics;

public class timemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public float LimitTime;


    // Update is called once per frame
    void Update()
    {
        LimitTime += Time.deltaTime;
        Debug.Log(LimitTime);
    }
}
