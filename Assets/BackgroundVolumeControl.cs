using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundVolumeControl : MonoBehaviour
{
    MusicPlayer music;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<MusicPlayer>();
        slider = GetComponent<Slider>();
        slider.value = music.GetVolume();
    }

    public void SetBackgroundVolume(float sliderValue)
    {
        if (music)
        {
            music.SetVolume(sliderValue);
        }
    }

}
