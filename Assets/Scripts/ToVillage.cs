using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToVillage : MonoBehaviour
{
    public void EnterVillage(){
        SceneManager.LoadScene("Village");
    }
}
