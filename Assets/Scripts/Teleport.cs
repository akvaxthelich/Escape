using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform dest;

    private void OnTriggerEnter(Collider other)
    {
        print("Teleporting: " + other.tag);
        if (other.tag == "Player")
        {
            CharacterController cc = other.gameObject.GetComponent<CharacterController>();

            cc.enabled = false;
            TeleportTo(cc.gameObject, dest);
            cc.enabled = true;
        }
    }

    void TeleportTo(GameObject g, Transform dest)
    {

        g.transform.position = dest.position;

    }
}
