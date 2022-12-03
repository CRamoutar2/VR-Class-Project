using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject Done;
    public GameObject NotDone;
    public GameObject Awaiting;

    public static ScoreManager instance;

    public Text CactiScore;
    public Text WheatScore;
    public Text AppleScore;
    public Text ScarabScore;

    public static int Cscore {get; set;}
    public static int Wscore {get; set;}
    public static int Ascore {get; set;}
    public static int Sscore {get; set;}

    private void Awake(){
        instance = this;
        DontDestroyOnLoad(instance);
    }
    
    void Start()
    {   
        CactiScore.text = Cscore.ToString();
        WheatScore.text = Wscore.ToString();
        AppleScore.text = Ascore.ToString();
        ScarabScore.text = Sscore.ToString();
        
    }

    public void AddCactiScore(){
        Cscore += 1;
        CactiScore.text = Cscore.ToString();
    } 
    
    public void AddWheatScore(){
        Wscore +=1;
        WheatScore.text = Wscore.ToString();
    }
    public void AddAppleScore(){
        Ascore +=1;
        AppleScore.text = Ascore.ToString();
    }
    public void AddScarabScore(){
        Sscore +=1;
        ScarabScore.text = Sscore.ToString();
    }

    public void CheckForCompletion(){
        if(Cscore < 3 && Wscore < 3 && Ascore < 3  && Sscore < 3){
            NotDone.SetActive(true);
            Awaiting.SetActive(false);
        }
        else if(Cscore >= 3 && Wscore >= 3 && Ascore >= 3  && Sscore >= 3){
            Done.SetActive(true);
            Awaiting.SetActive(false);
        }
    }
}
