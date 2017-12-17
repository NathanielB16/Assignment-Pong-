using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadTheLevel(string LevelName) //Function called LoadTheLevel
    {
        SceneManager.LoadScene(LevelName); 
    }

    public void Quit_Game() //Function called Quit_Game
    {
 
        SceneManager.LoadScene(0); //Load scene with build index 0

    }

    public void LoadTheNextLevel() //Function called LoadTheNextLevel
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load the next level by incrementing
    }

}
