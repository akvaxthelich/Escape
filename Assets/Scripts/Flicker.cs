using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public Light light;
    float regularIntensity;
    float coolUp; //how often to flicker

    float timer;
    void Start()
    {
        light = GetComponent<Light>();
        regularIntensity = light.intensity;
        timer = 0f;
        coolUp = 0.12f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= coolUp +- 0.02f) {
            light.intensity = Random.Range(regularIntensity - 0.25f, light.intensity + 0.25f);
            timer = 0f;
        }
        
        timer += Time.deltaTime;

    }
}
