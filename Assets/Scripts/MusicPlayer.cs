using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    void Awake()
    {
        SetUpSingleton();
        audioSource = GetComponent<AudioSource>();
    }

    private void SetUpSingleton()
    {
        // GetType will return the object of the class, i.e. MusicPlayer 
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public float GetVolume()
    {
        return audioSource.volume;
    }

    public bool ToggleSound()
    {
        if (gameObject.GetComponent<AudioSource>().mute)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
