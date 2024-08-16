using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Xml.Serialization;
using TMPro;

public class GameMAnager : MonoBehaviour
{
    public TextMeshProUGUI YourScoretext;
    public GameObject winpanel;
    public TextMeshProUGUI DeathScore,DefeatCoinText;
    float timer=10f;
    bool timerbool=false;
    public TextMeshProUGUI timertext;
    public GameObject Settings;
    public Transform U_border,B_border;//for boss
    Vector3 borderoffset;
    public Animator headinganimator;
    public TextMeshProUGUI Waveheading;
    bool cont=false;
    int score=0,waveno=0;
    public Text scoretext;
    public GameObject After_lose1,After_lose2;
    // public void OpenL02()
    // {
    //     levels_lock.L02_lock.SetActive(false);
    // }
    void Update()
    {

        if(timerbool)
        {
            timertext.text=timer.ToString("0");
            timer-=1*Time.deltaTime;
        }
    }
    void Start()
    {
        if(headinganimator!=null)
        {
            WaveH_Change();
        }
        
    }
    public void SttingsOpen()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        Settings.SetActive(true);
    }
    public void SttingsClose()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        Settings.SetActive(false);
    }
    public void BorderChange()
    {
        borderoffset=transform.position;
        borderoffset.y-=13;
        B_border.position=borderoffset;
        borderoffset.y+=21;
        U_border.position=borderoffset;
    }
    public void Wave_lvls()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        bulletcollision.EnemyKilled=0;
        SceneManager.LoadScene("Main Level");//For enetring waves
    }
    public void DefeatScore(int Deathtime)
    {
        int EnemeiesKilled=Startgame.EnemiesKilled;
        DeathScore.text="Score:"+(EnemeiesKilled*600/Deathtime).ToString();
        if(DefeatCoinText!=null)
        {
            
            if(Startgame.EnemiesKilled>=46)
            {
                DefeatCoinText.text="6000";
                UIvarables.coins+=6000;
            }
            else if(Startgame.EnemiesKilled>=15)
            {
                DefeatCoinText.text="3000";
                UIvarables.coins+=3000;
            }
            else
            {
                DefeatCoinText.text="0";
                UIvarables.coins+=0;
            }
        }
    }
    public void Lost1()
    {
        timer=10f;
        Time.timeScale=1f;
        After_lose1.SetActive(true);
        Invoke("Lost2",10f);
        timerbool=true;
    }
    public void Lost2()
    {
        if(timer>0f)
        {
            FindObjectOfType<AudioManager>().SfxPlay("Click");
        }
        Debug.Log(!cont);
        if(!cont)
        {
            Time.timeScale=1f;
            After_lose1.SetActive(false);
            After_lose2.SetActive(true);
            Startgame.EnemiesKilled=0;
        }
        cont=false;   
    }
    public void Continue()
    {
        timerbool=false;
        FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
        if(UIvarables.coins>=3000)
        {
            Debug.Log("ENTERED continue");
            UIvarables.coins-=3000;
            After_lose1.SetActive(false);
            cont=true;
            FindObjectOfType<PlayerCollisiion>().Continuegame();
        }
    }
    // public void BacktoHome(string shipname)
    // {
    //     Debug.Log(shipname);
    //     SceneManager.LoadScene("UI");
        
    // }
    public void Spaceships()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        SceneManager.LoadScene("Spaceships");
    }
    public void BacktoHome()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        SceneManager.LoadScene("UI");
    }
    public void scoreinc()
    {
        score+=10;
        scoretext.text="Score:"+score.ToString();
    }
    public void Lvlselction(string level)
    {
        SceneManager.LoadScene(level);
    }
    //GameMAnager gamemanager;
    public void Tolvls()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Endgame()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        restart();
    }
    void restart()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene("UI");
    }
    public void WaveH_Change()
    {
        waveno++;
        Debug.Log(waveno);
        Waveheading.text = "-- WAVE " + waveno.ToString() + " --";
        headinganimator.SetBool("Heading", true);
        Invoke("HeadingGo", 2f);
    }
    public void FinalWaveH()
    {
        waveno++;
        Debug.Log(waveno);
        Waveheading.text = "-- WAVE 15 --" ;
        headinganimator.SetBool("Heading", true);
        Invoke("HeadingGo", 2f);
    }
    public void WavesCompletedH()
    {
        waveno++;
        Debug.Log(waveno);
        Waveheading.text = "-- WAVES COMPLETED --" ;
        headinganimator.SetBool("Heading", true);
        Invoke("HeadingGo", 2f);
        Invoke("getout", 2f);
        
    }
    void HeadingGo()
    {
        headinganimator.SetBool("Heading",false);
    }
    void getout()
    {
        float time=FindObjectOfType<Lvlcmp>().Telltime();
        YourScoretext.text="Score:"+(82*600/(int)time).ToString();
        winpanel.SetActive(true);
    }
}
