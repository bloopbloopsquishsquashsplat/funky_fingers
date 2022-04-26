using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
=======

>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
public class Dj : MonoBehaviour
{
    private float bramptom_bpm = 99;
    private int beat = 1;
    private AudioSource bramptom;
<<<<<<< HEAD
    private float[] spectrum = new float[256];
=======
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
    public int song_position;
 
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        //bramptom = GetComponent<AudioSource>();
        //get filename from options scene
        //AudioClip clip = (AudioClip)Resources.Load("audiofilename");
        //audio.PlayOneShot(clip);
=======
        bramptom = GetComponent<AudioSource>();
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //bramptom.Play();
        //audio.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
=======
        bramptom.Play()
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
    }
}
