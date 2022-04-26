using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]
<<<<<<< HEAD
public class Sound
=======
public class Sound : MonoBehaviour
>>>>>>> fd7f2704a10aab6806d65f1dbf3e4f5bc498c11b
{
    public string name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;
    //check if there is a decimal
    [Range(1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

}
