using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementShite : MonoBehaviour
{

    CharacterController _cc;
    float _speed = 6f;
    float _gravity = Physics.gravity.y;

    public float jumpHeight;
    bool _onGround;
    float _maxDist = 0.75f;
    float _sphRadius = 0.70f;
    int _groundLayerMask;


    Vector3 moveInput;
    Vector3 _velocity;

    void Start()
    {
        
        _cc = GetComponent<CharacterController>();
        _velocity = Vector3.zero;
        _groundLayerMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        
        _onGround = Physics.SphereCast(transform.position, _sphRadius, -transform.up, out RaycastHit hit, _maxDist + 0.01f, _groundLayerMask);


        #region Mario physics
        //character should spend half the time going down as they do going up

        if (Input.GetButtonDown("Jump") && _onGround)
        {
            //v = sqrt of jumpheight * -2 * gravity (as long as gravity is negative) 
            _velocity.y = Mathf.Sqrt(jumpHeight * -2 * _gravity);
        }
        if (_velocity.y < 0f) //if moving down
        {

            _gravity = Physics.gravity.y * 2f;

        }
        else { 
        
            _gravity = Physics.gravity.y;
        }


        #endregion

        #region Ground-based Movement

        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        Vector3 moveDir = transform.forward * moveInput.z + transform.right * moveInput.x;

        //Move on x and z
        _cc.Move(moveDir * _speed * Time.deltaTime);

        #endregion

        #region Air and Vertical movement (jumping + gravity)
        if (!_onGround)
        {

            _velocity.y += _gravity * (Time.deltaTime); // m/s ^2 

        }
        if (_velocity.y < 0 && _onGround) {

            _velocity.y = 0f;

        }
        
        _cc.Move(_velocity * Time.deltaTime);
        #endregion

    }


}
