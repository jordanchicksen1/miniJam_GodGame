using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Timez;
    void Update()
    {
        Timez += Time.deltaTime;
    }
}
