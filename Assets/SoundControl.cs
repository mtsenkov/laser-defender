using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    MusicPlayer music;

    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<MusicPlayer>();
    }

    public void ToggleMuteIcon()
    {
        if (music.ToggleSound())
        {
            music.GetComponent<AudioSource>().mute = false;
        } else
        {
            music.GetComponent<AudioSource>().mute = true;
        }
    }

    private void UpdateVolume()
    {
        if(music.GetComponent<AudioSource>().mute)
        {
            AudioListener.volume = 1;
        } else
        {
            AudioListener.volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
