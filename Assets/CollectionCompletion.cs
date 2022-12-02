using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Collection_Completion : MonoBehaviour
{
    public GameObject Done;
    public GameObject NotDone;

    public void CheckFortCompletion(){
        if(ScoreManager.Cscore < 3 && ScoreManager.Wscore < 3 && ScoreManager.Ascore < 3  && ScoreManager.Sscore < 3){
            NotDone.SetActive(true);
        }
        else if(ScoreManager.Cscore >= 3 && ScoreManager.Wscore >= 3 && ScoreManager.Ascore >= 3  && ScoreManager.Sscore >= 3){
            Done.SetActive(true);
        }
    }
}
