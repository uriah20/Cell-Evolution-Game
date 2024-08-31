using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer theMixer;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            theMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
        }
        
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            theMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
        }
    }
}
