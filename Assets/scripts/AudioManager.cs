using UnityEngine.Audio;
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    //get all sounds in resources folder, make object array size
    //equal number of mp3 files.
    //assign each object in array of sounds with filename
    
    // Start is called before the first frame update
    public Sound[] sounds;
    public static AudioSource Song;
    void Awake()
    {
        DontDestroyOnLoad(this);
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
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
                s.source.Play();
            }
        }
    }

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
	
	public void ChooseSong()
	{
		foreach(Sound s in sounds)
        {
            if(s.source.isPlaying)
            {
                Song = s.source;
            }
        }
		Debug.Log("GotSong!");
		Debug.Log(Song);
	}

	public void PlayChosenSong()
	{
		if (Song)
		{
			Song.time = 0;
			Song.Play();
		}else
		{
			Debug.Log("no song loaded. AudioManager.cs Line:72");
		}
	}

}

