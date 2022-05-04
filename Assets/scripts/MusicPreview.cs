using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Audio;
[System.Serializable]
public class MusicPreview : MonoBehaviour
{
    //change it from public when function call passing parameter songChoice is made
    public static string songChoice;
    protected string songPreviewed;
    //ButtonSongName bsn;
    public string BtnTest(Button btn)
    {
        return btn.name;
    }
    
    //IEnumerator Start()
    
    
    public void OnMouseOver(Button btn)
    {
        songPreviewed="";
        //Debug.Log(btn.name);
        
        ButtonSongName bsn = GameObject.FindObjectOfType<ButtonSongName>();
        
        
        //yield return new WaitForEndOfFrame();
        
        if (System.IO.File.Exists("Assets/Resources/sounds/funky_fingers_music/ghost.mp3"))
            {
                //Debug.Log("exists");
            }
        
        foreach(KeyValuePair<string, Button> item in bsn.namesToButtons)
        {
           
            //Item.Key is the filename string
            Button dictcurr = item.Value;
            //Debug.Log(dictcurr.name);
            
            if(dictcurr.name == btn.name)
            {
                songPreviewed = item.Key;
                playCurrent(item.Key);
                //FindObjectOfType<AudioManager>().Play(item.Key);
                
                
                
            }
            
        }
       
       
       btn.onClick.AddListener(Click);
        //if(btn.IsPressed())
        //{
            //songChoice = songPreviewed;
            //Debug.Log(songChoice);
        //}
        
        
    }

    
    public static void playCurrent(string sname)
    {
        FindObjectOfType<AudioManager>().Play(sname);
    }
    public void OnMouseExit()
    {
        FindObjectOfType<AudioManager>().Stop();
        
    }
    
    public void Click()
    {
        songChoice = songPreviewed;
        Debug.Log(songChoice);
    }
    

}

/*
 Text buttonText = buttons[i].GetComponentInChildren<Text>();
        
 buttonText.text = songNames[i];
*/
