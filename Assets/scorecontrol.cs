using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class scorecontrol : MonoBehaviour
{
    public static scorecontrol instance;
    public void Awake(){
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text p1Score;
    public Text p2Score;
    int score1 = 0;
    int score2 = 0;
    void Start()
    {
        p1Score.text = score1.ToString();
        p2Score.text = score2.ToString();
    }

    public void addP1(){
        score1 += 1;
        p1Score.text = score1.ToString();
    }
    public void addP2(){
        score2+= 1;
        p2Score.text = score2.ToString();
    }
}
