using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] sounds; 
    public AudioSource musicsource,sfxsource;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance==null)
        {
            Instance=this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        foreach (Sound s in sounds)
        {
            s.source=gameObject.GetComponent<AudioSource>();
            s.source.clip=s.clip;
            s.source.volume=s.volume;
            s.source.pitch=s.pitch;
        }
    }
    void Start()
    {
        FindObjectOfType<AudioManager>().MusicPlay("Bgm");
    }
    public void SfxPlay(string name)
    {
        //Sound s;
        // Sound s=Array.Find(sounds, sound=> sound.name==name);
        foreach (Sound s in sounds)
        {
            if(s.name==name)
            {
                Debug.Log("FOUND"+s.name);
                sfxsource.clip=s.clip;
                // sfxsource.volume=s.volume;
                sfxsource.Play();
                break;
            }
        } 
    }
    public void MusicPlay(string name)
    {
        //Sound s;
        // Sound s=Array.Find(sounds, sound=> sound.name==name);
        foreach (Sound S1 in sounds)
        {
            if(S1.name==name)
            {
                Debug.Log("FOUND"+S1.name);
                musicsource.clip=S1.clip;
                //musicsource.volume=S1.volume;
                musicsource.Play();
                break;
            }
        } 
        
    }
    // Update is called once per frame
    public void MusicChange(float volume)
    {
        musicsource.volume=volume;
    }
    public void SfxChange(float volume)
    {
        sfxsource.volume=volume;
    }
}
