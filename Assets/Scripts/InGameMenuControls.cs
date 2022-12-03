using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class InGameMenuControls : MonoBehaviour
{
    public GameObject Ui;
    void Update(){
        if(/*Input.GetKeyDown(KeyCode.G) || */Input.GetKeyDown("joystick button 0") && !Ui.activeSelf){
            Ui.SetActive(true);
        }
        else if (/*Input.GetKeyDown(KeyCode.G) || */Input.GetKeyDown("joystick button 0") && Ui.activeSelf){
            Ui.SetActive(false);
        }
    }
}
