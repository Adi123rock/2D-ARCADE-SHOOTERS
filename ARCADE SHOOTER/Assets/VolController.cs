using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolController : MonoBehaviour
{
    public Slider MusicSlider,Sfxslider;
    static float value_Music=1,value_Sfx=1;
    void Start()
    {
        MusicSlider.value=value_Music;
        Sfxslider.value=value_Sfx;
    }
    public void MusicOff()
    {
        AudioManager.Instance.MusicChange(0);
    }
    public void SfxOff()
    {
        AudioManager.Instance.SfxChange(0);
    }
    public void MusicChange()
    {
        value_Music=MusicSlider.value;
        //AudioManager.musicsource.volume=MusicSlider.value;
        AudioManager.Instance.MusicChange(value_Music);
    }
    public void SfxChange()
    {
        value_Sfx=Sfxslider.value;
        //AudioManager.musicsource.volume=MusicSlider.value;
        AudioManager.Instance.SfxChange(value_Sfx);
    }
}
