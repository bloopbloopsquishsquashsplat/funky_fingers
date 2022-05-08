using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]
public class Sound : MonoBehaviour
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
