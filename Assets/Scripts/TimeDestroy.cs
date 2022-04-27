using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    void FixedUpdate()
    {
        StartTime += 1f * Time.deltaTime;

        if(StartTime >= EndTime)
        {
            Destroy(gameObject);
        }
    }
}
