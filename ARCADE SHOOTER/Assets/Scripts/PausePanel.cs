using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{ 
    public GameObject Paupanel,VolumeOn,VolumeOff; 
    
    public void Pausepan()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        Time.timeScale=0f;
        Paupanel.SetActive(true);
        off();
    }
    public void Resume()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        Time.timeScale=1f;
        Paupanel.SetActive(false);
    }
    public void Volon()
    {
        FindObjectOfType<AudioManager>().SfxChange(1);
        FindObjectOfType<AudioManager>().MusicChange(1);
        VolumeOn.SetActive(true);
        VolumeOff.SetActive(false);
    }
    public void Voloff()
    {
        FindObjectOfType<AudioManager>().SfxChange(0);
        FindObjectOfType<AudioManager>().MusicChange(0);
        VolumeOff.SetActive(true);
        VolumeOn.SetActive(false);
    }
    public void Home()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        Time.timeScale=1f;
        SceneManager.LoadScene("UI");
    }
    void off()
    {
        Debug.Log("OFF");
        FindObjectOfType<Obstaclefiring>().enabled=false;
    }
}
