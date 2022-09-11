using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    
    SpriteRenderer sr;
    float timer;

    //flip portal back and forth
    //maybe particles?
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x,transform.position.y + (0.5f * Mathf.Sin(Time.time)) * Time.deltaTime ,transform.position.z);
        
    }


}
