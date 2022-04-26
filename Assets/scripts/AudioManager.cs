using UnityEngine.Audio;
using UnityEngine;
<<<<<<< HEAD
using System.Collections;

=======
[Serializable]
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
public class AudioManager : MonoBehaviour
{
    //get all sounds in resources folder, make object array size
    //equal number of mp3 files.
    //assign each object in array of sounds with filename
<<<<<<< HEAD
    
    // Start is called before the first frame update
    public Sound[] sounds;
    
    
    void Awake()
    {
        
=======
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
<<<<<<< HEAD
           //
           s.source.volume = 1;
           //s.source.volume = s.volume;
           //s.source.pitch = s.pitch;
        }
        
    }

    // Update is called once per frame
    public void Play(string nameInput)
    {
        foreach(Sound s in sounds)
        {
            if(s.name == nameInput)
            {
                s.source.time = 10;
                //s.source.PlayClipAtPoint(s.clip, new Vector3(5, 1, 2));
=======
           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        foreach(Sound s in sounds)
        {
            if(s.name == name)
            {
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
                s.source.Play();
            }
        }
    }
<<<<<<< HEAD

    public void Stop()
    {
        foreach(Sound s in sounds)
        {
            if(s.source.isPlaying)
            {
                s.source.Stop();
            }
        }
    }
    
=======
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
}
