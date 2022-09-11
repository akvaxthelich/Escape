using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    TextMeshProUGUI tm;
    float startTime = 120f; 
    float time;
    void Start()
    {
        tm = GetComponent<TextMeshProUGUI>();
        time = startTime;
        tm.text = startTime + "s";
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        tm.text = time.ToString("#.00") + "s";

        if (time <= 0) { 
        
            //game over scene
        
        }

    }
}
