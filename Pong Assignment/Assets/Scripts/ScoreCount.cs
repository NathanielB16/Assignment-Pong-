using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

    public static ScoreCount instance;

    public Text P1_Score_text; //Declaring 2 text variables
    public Text P2_Score_text;

    public int P1_Score; //Declaring 2 variables of data type int
    public int P2_Score;

    public int Max_Points = 3; //Setting Maximum points to 3


    void Start () {

        instance = this;

        P1_Score = 0; //Initialising both variables to 0
        P2_Score = 0;

    }
	
	
	void Update () {

		if(P1_Score >= Max_Points || P2_Score >= Max_Points) //When Max Points are reached load the next Level
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
	}

    public void P1_Point()
    {
        P1_Score += 1; //Incrementing P1_score by 1

        P1_Score_text.text = P1_Score.ToString(); //Converting the P1_score text to String
    }

    public void P2_Point()
    {
        P2_Score += 1; //Incrementing P2_score by 1

        P2_Score_text.text = P2_Score.ToString(); //Converting the P2_score text to String
    }
}
