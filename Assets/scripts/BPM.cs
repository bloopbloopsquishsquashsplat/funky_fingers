using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour
{
    //public List<GameObject> arrows = new List<GameObject>();
    private float[] spectrum;
    private AudioManager am;
    private static BPM beatspermin;
    
    public static float specValue
    {
        get;
        private set;
    }
    public const FFTWindow Window = FFTWindow.BlackmanHarris;
    // Start is called before the first frame update
    void Start()
    {
        string song = MusicPreview.songChoice;
        //correct song is displayed (2:26 May 1st 2022)
        Debug.Log(song);
        am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        am.Play(song);
    }
    /*
    void AnalyzeSpectrum()
    {
        int size = 256;
        float sum = 0.0f;
        spectrum = new float[size];
        
        //originally was in update
        //think of each element as a wave
        AudioListener.GetSpectrumData(spectrum, 0, Window);
        //int outRate = AudioSettings.outputSampleRate;
        float bin = ((float)AudioSettings.outputSampleRate / 2.0f) / (float)size;
        for (int i=0; i<size; i++)
        {
            sum += spectrum[i];
            /*if(spectrum[i]!=0f)
            {
                sum += spectrum[i];
            }
            else
            {
                size--;
            }
            
        }
        float avg = sum / (float)size;
        
        //int beat = 0;
        for(int i=0; i <size; i++)
        {
            if((spectrum[i])>avg*100)
            {
                //beat++;
                int rand = Random.Range(0,4);
                GameObject curr = ArrowMovement.arrows[rand];
                curr.transform.position = new Vector2(ArrowMovement.xvalues[rand], 50);
                
                
                Move(curr);
                //StartCoroutine(Move());
                
            }
        }
        //Debug.Log(bin);
        //Debug.Log(spectrum[9]);
        //Debug.Log(spectrum[10]);
        //Debug.Log(spectrum[11]);
    }
    // Update is called once per frame
    void Move(GameObject game)
    {
        
            //change constant seconds to respawn
            //yield return new WaitForSeconds(2f);
            transform.position -= new Vector3(0f, 100 * Time.deltaTime, 0f);
            //Debug.Log(game.transform.position.y);
        
    }
    void Update()
    {
        AnalyzeSpectrum();
        
        //AudioListener.GetSpectrumData(spectrum, 0, Window);
        
        //if(spectrum != null && spectrum.Length > 0)
        //{
        //    specValue = spectrum[0] * 100;
        //}
    }
    */
}
