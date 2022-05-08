using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ButtonSongName : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Dictionary<string, Button> namesToButtons = new Dictionary<string, Button>();
    void Start()
    {
        ScreenLoader.isReady=false;
        //string of music taken from folder in computer
        //Tried using Application.dataPath but this goes to Assets folder only, not to music and doesn't work
        //"/home/eswaggy1234/sounds"
        string[] musicFiles = Directory.GetFiles("Assets/Resources/sounds/funky_fingers_music", "*.mp3");
        
        
        //get song name of each mp3 file.
        //each file has the name stored between \ and .mp3

        string[] songNames = new string[musicFiles.Length];
        for(int i = 0; i < musicFiles.Length; i++)
        {
            //previous code
            //int lengthToCut = musicFiles[i].IndexOf(@".")-musicFiles[i].IndexOf(@"\")-1;
            
            int lastSlash = musicFiles[i].LastIndexOf(@"/", musicFiles[i].IndexOf(@"."))+1;
            int lengthToCut = musicFiles[i].IndexOf(@".")-lastSlash;
            //previous code
            //string songName = musicFiles[i].Substring(musicFiles[i].IndexOf(@"\")+1, lengthToCut);
            string songName = musicFiles[i].Substring(lastSlash, lengthToCut);
            

            songNames[i] = songName;
            //Name of music file
            //Debug.Log(musicFiles[i]);
        }
        //All buttons in current game object and current screen are stored in an array
        Button[] buttons = this.GetComponentsInChildren<Button>();

        //Each button's text is replaces with the song name
        for(int i = 0; i < buttons.Length; i++)
        {
            Text buttonText = buttons[i].GetComponentInChildren<Text>();

            namesToButtons.Add(songNames[i], buttons[i]);
        
            buttonText.text = songNames[i];
        }
        

    
    }

   //function to check dictionary if it contains the given UI, if so return filename
}


