using UnityEngine.Audio;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    //get all sounds in resources folder, make object array size
    //equal number of mp3 files.
    //assign each object in array of sounds with filename
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play(string name)
    {
        foreach(Sound s in sounds)
        {
            if(s.name == name)
            {
                s.source.time = 10;
            }
        }
    }
}
