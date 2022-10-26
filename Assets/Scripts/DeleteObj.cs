using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeleteObj : MonoBehaviour
{

    void Update()
    {
        /*if((Input.GetKeyDown("joystick button 15"))
        {
                Destroy(transform.gameObject);
        }*/
        

        RaycastHit hit;
        /*var inputDevices = new List<UnityEngine.XR.InputDevice>();
        bool triggerValue;
        foreach(var device in inputDevices){
            if(Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if(device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue)){
                    Destroy(hit.transform.gameObject);
                }
            }
        }*/
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log("Hit Detected");
            if((Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Destructable"){
                Destroy(hit.transform.gameObject);
            }
        }
    }
}

