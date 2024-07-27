using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerCollisiion : MonoBehaviour
{
    float Deathtime;
    public GameObject ShieldPowerup,pfabshield;//for powerups
    public static bool shield=true;// For shield (powerup)
    public Transform camerapos;//for boss
    Vector3 offset;
    public bool once=true;
    public GameObject gameovr;
    //public GAmeOver gAmeOver;
    public forceapply movement;
    float health=100f;
    public float delay=1f;
    public Transform expeffect;
    public GameObject explosionEffect;
    public Text healthtext;
    //public GameMAnager gamem;
    void Start()
    {
        Changehealth();
        healthtext.text="HP:"+health.ToString();
    }
    public void Changehealth()
    {
        health=HealthBar.health;
    }
    void OnTriggerEnter2D (Collider2D Collisioninfo)
    {
        Debug.Log("ontrigger");
        Debug.Log(Collisioninfo);
        if((Collisioninfo.tag=="Bullet" || Collisioninfo.tag=="Obstacle") && shield)
        {
            if(health>0){
                health-=50f;
            }
            healthtext.text="HP:"+health.ToString();
            Leshift();
            if(health==0f && once)
            {
                Deathtime=FindObjectOfType<Lvlcmp>().Telltime();
                FindObjectOfType<GameMAnager>().DefeatScore((int)Deathtime);
                once=false;
                movement.enabled=false;
                expeffect.position=transform.position;
                explosionEffect.SetActive(true);
                FindObjectOfType<AudioManager>().SfxPlay("PlayerDeath");
                // Instantiate(explosionEffect,transform.position,transform.rotation);
                Invoke("Gamedone",1f);
                Invoke("GameOver",delay*1f);  
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().SfxPlay("ShieldCollision");
        }
        if(Collisioninfo.tag=="Shield")
        {
            FindObjectOfType<AudioManager>().SfxPlay("ShieldEquip");
            Destroy(ShieldPowerup);
            // FindObjectOfType<PlayerCollisiion>().enabled=false;
            shield=false;
            Debug.Log("Shield On");
            ShieldPowerup.SetActive(false);
            Invoke("Shieldoff",5f);
            pfabshield.SetActive(true);
        }
        if(Collisioninfo.tag=="Boss")
        {
            FindObjectOfType<Boss>().enabled=true;
            FindObjectOfType<followplayer>().enabled=false;
            FindObjectOfType<GameMAnager>().BorderChange();
            // offset=camerapos.position;
            // offset.y+=2;
            // camerapos.position=offset;
        }
    }
    void Shieldoff()
    {
        shield=true;
        pfabshield.SetActive(false);
        // FindObjectOfType<PlayerCollisiion>().enabled=true;
        Debug.Log("Shield off");
    }
    void GameOver()
    {
        //Destroy(gameObject);
        gameovr.SetActive(false);
        explosionEffect.SetActive(false);
        FindObjectOfType<GameMAnager>().Lost1();
    }
    void Leshift()
    {
        //FindObjectOfType<followplayer>().Leftshift();
        FindObjectOfType<HealthBar>().Dechbar();
    }
    void Gamedone()
    {
        gameovr.SetActive(true);
    }
    public void Continuegame()
    {
        Time.timeScale=1f;
        once=true;
        health=HealthBar.health;
        healthtext.text="HP:"+health.ToString();
        movement.enabled=true;
        FindObjectOfType<HealthBar>().Fullhp();
    }
    
}
