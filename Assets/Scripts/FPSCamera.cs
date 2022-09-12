using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public GameObject cc; //ref character controller for rotation about y axis

    float _senseX = 350;
    float _senseY = 350; //default sense to 100 for both. may change later

    float xRotation;
    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //center mousepos
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * _senseX; //keep smoothing filter for that extra bit of polish
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * _senseY; 
        
        yRotation += mouseX; 
        xRotation -= mouseY;

        //clamp so we dont go super mario galaxy mode:
        xRotation = Mathf.Clamp(xRotation, -90f, 90); //Remember, this is rotation ABOUT the X axis, not along it.
        //like walking into a pole at waist height
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        
        cc.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);

    }
}
