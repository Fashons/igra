using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeСhange : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    void FixedUpdate()
    {
        StartTime += 1f * Time.deltaTime;

        if (StartTime >= EndTime)
        {
            GetComponent<Text>().text = "Давай я научу тебя играть";
        }
    }
}