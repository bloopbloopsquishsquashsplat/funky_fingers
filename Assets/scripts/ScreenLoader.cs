using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public static bool isReady=true;

    public void LoadNextScene()
    {
        int currSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(isReady==true)
        {
            SceneManager.LoadScene(currSceneIndex+1);
        }
        
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);

        //test
    }
    
	public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

	public void PlayGame()
	{
		SceneManager.LoadScene(1);
		
		//AudioManager.PlayChosenSong();
	}

    public void PauseScreen()
    {
        SceneManager.LoadScene(2);
    }
}
