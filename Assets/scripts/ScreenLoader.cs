using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    
    public void LoadNextScene()
    {
        int currSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currSceneIndex+1);

    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
<<<<<<< HEAD
        //test
=======
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
    }
    
}
