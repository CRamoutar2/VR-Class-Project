using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeleteObj : MonoBehaviour
{
    public AudioSource Deletionsound;
    void Update()
    {
         RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if((Input.GetKeyDown("space") ||Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Cacti"){
                Destroy(hit.transform.gameObject);
                Deletionsound.Play(0);
                ScoreManager.instance.AddCactiScore();
            }
            else if((Input.GetKeyDown("space") ||Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Wheat"){
                Destroy(hit.transform.gameObject);
                Deletionsound.Play(0);
                ScoreManager.instance.AddWheatScore();
            }
            else if((Input.GetKeyDown("space") ||Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Apple"){
                Destroy(hit.transform.gameObject);
                Deletionsound.Play(0);
                ScoreManager.instance.AddAppleScore();
            }
            else if((Input.GetKeyDown("space") ||Input.GetKeyDown("joystick button 15") || Input.GetKeyDown("joystick button 14")) && hit.transform.gameObject.tag == "Scarab"){
                Destroy(hit.transform.gameObject);
                Deletionsound.Play(0);
                ScoreManager.instance.AddScarabScore();
            }
        }
    }
}

