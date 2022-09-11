using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + (0.2f * Mathf.Sin(Time.time)) * Time.deltaTime, transform.position.z);
    }

}
