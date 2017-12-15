using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

    public static ScoreCount instance;

    public Text P1_Score_text;
    public Text P2_Score_text;

    public int P1_Score;
    public int P2_Score;


    void Start () {

        instance = this;

        P1_Score = 0;
        P2_Score = 0;

    }
	
	
	void Update () {
		
	}

    public void P1_Point()
    {
        P1_Score += 1;

        P1_Score_text.text = P1_Score.ToString();
    }

    public void P2_Point()
    {
        P2_Score += 1;

        P2_Score_text.text = P2_Score.ToString();
    }
}
