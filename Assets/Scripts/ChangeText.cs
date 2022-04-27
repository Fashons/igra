using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeText : MonoBehaviour
{
    public float StartTime;
    public float EndTime;
    private Text myText;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        StartTime += 1f * Time.deltaTime;

        if (StartTime >= EndTime)
        {
            myText.enabled = !myText.enabled;
        }
    }
}