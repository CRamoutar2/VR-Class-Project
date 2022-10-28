using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeleteObj : MonoBehaviour
{

    void Update()
    {
         RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if((Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Destructable"){
                Destroy(hit.transform.gameObject);
            }
        }
    }
}

