using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadTheLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

    public void Quit_Game()
    {
 
        SceneManager.LoadScene(0);

    }



    public void LoadTheNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
