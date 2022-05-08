using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dj : MonoBehaviour
{
    private float bramptom_bpm = 99;
    private int beat = 1;
    private AudioSource bramptom;
    public int song_position;
 
    // Start is called before the first frame update
    void Start()
    {
        bramptom = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bramptom.Play();
    }
}
