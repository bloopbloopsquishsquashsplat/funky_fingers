using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class Dj : MonoBehaviour
{
    private float bramptom_bpm = 99;
    private int beat = 1;
    private AudioSource bramptom;
    private float[] spectrum = new float[256];
    public int song_position;
 
    // Start is called before the first frame update
    void Start()
    {
        //bramptom = GetComponent<AudioSource>();
        //get filename from options scene
        //AudioClip clip = (AudioClip)Resources.Load("audiofilename");
        //audio.PlayOneShot(clip);
        
    }

    // Update is called once per frame
    void Update()
    {
        bramptom.Play();
    }
}
