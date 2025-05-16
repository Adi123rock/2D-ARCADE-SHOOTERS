using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spship_changer : MonoBehaviour
{
    
    string namespaceship=UIvarables.namespaceship;
    public GameObject S_1,S_2,S_3,S_4,S_5,S_6;
    void Start()
    {
        namespaceship=UIvarables.namespaceship;
    }
    void Update()
    {
        Changespship();
    }
    public void Changespship()
    {
        if(namespaceship=="S_1")
        {
            S_1.SetActive(true);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_1.transform;
            bulletcollision.damage=SAVETRY.P1.dmg;
            HealthBar.health=SAVETRY.P1.hp;
        }
        else if(namespaceship=="S_2")
        {
            S_1.SetActive(false);
            S_2.SetActive(true);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_2.transform;
            bulletcollision.damage=SAVETRY.P2.dmg;
            HealthBar.health=SAVETRY.P2.hp;
        }
        else if(namespaceship=="S_3")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(true);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_3.transform;
            bulletcollision.damage=SAVETRY.P3.dmg;
            HealthBar.health=SAVETRY.P3.hp;
        }
        else if(namespaceship=="S_4")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(true);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_4.transform;
            bulletcollision.damage=SAVETRY.P4.dmg;
            HealthBar.health=SAVETRY.P4.hp;
        }
        else if(namespaceship=="S_5")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(true);
            S_6.SetActive(false);
            followplayer.player=S_5.transform;
            bulletcollision.damage=SAVETRY.P5.dmg;
            HealthBar.health=SAVETRY.P5.hp;
        }
        else if(namespaceship=="S_6")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(true);
            followplayer.player=S_6.transform;
            bulletcollision.damage=SAVETRY.P6.dmg;
            HealthBar.health=SAVETRY.P6.hp;
        }
    }
    
}
