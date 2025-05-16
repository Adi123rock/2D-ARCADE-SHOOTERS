using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    //SAVETRY save;
    public TextMeshProUGUI Buycost,Upgcost;
    public TextMeshProUGUI Lvl_Spship, Hp_Spship, Dmg_Spship;
    public GameObject buy_button, upgrade_button;
    public GameObject next_button, prev_button, S_1, S_2, S_3, S_4, S_5, S_6;
    int i = 0;
    void Start()
    {
        // save=FindObjectOfType<SAVETRY>();
        // save.P1.level=2;
        // FindObjectOfType<SAVETRY>().Upd_details();
        nextspaceship();
    }
    public void BuySpacship()
    {
        if (S_2.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P2.Buycost && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=SAVETRY.P2.Buycost;
                SAVETRY.P2.unlock=true;
                // FindObjectOfType<SAVETRY>().
                FindObjectOfType<GameMAnager>().SavePlayer();
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<SAVETRY.P2.Buycost)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 2");
                }
                
            }
        }
        else if (S_3.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P3.Buycost && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=SAVETRY.P3.Buycost;
                SAVETRY.P3.unlock=true;
                // FindObjectOfType<SAVETRY>().
                FindObjectOfType<GameMAnager>().SavePlayer();
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<SAVETRY.P3.Buycost)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 2");
                }
                
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P4.Buycost && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=SAVETRY.P4.Buycost;
                SAVETRY.P4.unlock=true;
                // FindObjectOfType<SAVETRY>().
                FindObjectOfType<GameMAnager>().SavePlayer();
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<SAVETRY.P4.Buycost)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 2");
                }
                
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P5.Buycost && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=SAVETRY.P5.Buycost;
                SAVETRY.P5.unlock=true;
                // FindObjectOfType<SAVETRY>().
                FindObjectOfType<GameMAnager>().SavePlayer();
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<SAVETRY.P5.Buycost)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 2");
                }
                
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P6.Buycost && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=SAVETRY.P6.Buycost;
                SAVETRY.P6.unlock=true;
                // FindObjectOfType<SAVETRY>().
                FindObjectOfType<GameMAnager>().SavePlayer();
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<SAVETRY.P6.Buycost)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 2");
                }
                
            }
        }
        nextspaceship();
    }
    public void UpgSpacship()
    {
        if (S_1.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P1.Upgcost && SAVETRY.P1.unlock)
            {
                UIvarables.coins-=SAVETRY.P1.Upgcost;
                SAVETRY.P1.Upgcost+=500;
                SAVETRY.P1.level+=1;
                SAVETRY.P1.dmg+=10;
                SAVETRY.P1.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_2.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P2.Upgcost && SAVETRY.P2.unlock)
            {
                UIvarables.coins-=SAVETRY.P2.Upgcost;
                SAVETRY.P2.Upgcost+=500;
                SAVETRY.P2.level+=1;
                SAVETRY.P2.dmg+=10;
                SAVETRY.P2.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_3.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P3.Upgcost && SAVETRY.P3.unlock)
            {
                UIvarables.coins-=SAVETRY.P3.Upgcost;
                SAVETRY.P3.Upgcost+=500;
                SAVETRY.P3.level+=1;
                SAVETRY.P3.dmg+=10;
                SAVETRY.P3.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P4.Upgcost && SAVETRY.P4.unlock)
            {
                UIvarables.coins-=SAVETRY.P4.Upgcost;
                SAVETRY.P4.Upgcost+=500;
                SAVETRY.P4.level+=1;
                SAVETRY.P4.dmg+=10;
                SAVETRY.P4.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P5.Upgcost && SAVETRY.P5.unlock)
            {
                UIvarables.coins-=SAVETRY.P5.Upgcost;
                SAVETRY.P5.Upgcost+=500;
                SAVETRY.P5.level+=1;
                SAVETRY.P5.dmg+=10;
                SAVETRY.P5.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if(UIvarables.coins>SAVETRY.P6.Upgcost && SAVETRY.P6.unlock)
            {
                UIvarables.coins-=SAVETRY.P6.Upgcost;
                SAVETRY.P6.Upgcost+=500;
                SAVETRY.P6.level+=1;
                SAVETRY.P6.dmg+=10;
                SAVETRY.P6.hp+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                FindObjectOfType<GameMAnager>().SavePlayer();
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        nextspaceship();
    }
    public void SelectSpaceship()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        //SceneManager.LoadScene("UI");
        if (S_1.activeInHierarchy)
        {
            Debug.Log("S_1");
            UIvarables.namespaceship = "S_1";
            SceneManager.LoadScene("UI");
        }
        else if (S_2.activeInHierarchy)
        {
            if (SAVETRY.P2.unlock)
            {
                Debug.Log("S_2");
                UIvarables.namespaceship = "S_2";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }

        }
        else if (S_3.activeInHierarchy)
        {
            if (SAVETRY.P3.unlock)
            {
                Debug.Log("S_3");
                UIvarables.namespaceship = "S_3";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if (SAVETRY.P4.unlock)
            {
                Debug.Log("S_4");
                UIvarables.namespaceship = "S_4";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if (SAVETRY.P5.unlock)
            {
                Debug.Log("S_5");
                UIvarables.namespaceship = "S_5";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if (SAVETRY.P6.unlock)
            {
                Debug.Log("S_6");
                UIvarables.namespaceship = "S_6";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        /*
        if(S_1C.activeInHierarchy)
        {
            Debug.Log("S_1C");
            UIvarables.namespaceship="S_1C";
            SceneManager.LoadScene("UI");
        }
        if(S_2C.activeInHierarchy)
        {
            Debug.Log("S_2C");
            UIvarables.namespaceship="S_2C";
            SceneManager.LoadScene("UI");
        }
        if(S_1D.activeInHierarchy)
        {
            Debug.Log("S_1D");
            UIvarables.namespaceship="S_1D";
            SceneManager.LoadScene("UI");
        }
        if(S_2D.activeInHierarchy)
        {
            Debug.Log("S_2D");
            UIvarables.namespaceship="S_2D";
            SceneManager.LoadScene("UI");
        }
        */
    }
    /*
    public void Down()
    {
        prev_button.SetActive(false);
        next_button.SetActive(false);
        j++;
        Upgraded();
    }
    public void Up()
    {
        next_button.SetActive(true);
        if(i>0)
        {
            prev_button.SetActive(true);
        }
        
        j--;
        Upgraded();
    }
    */
    public void Previous()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        i--;
        nextspaceship();
    }
    public void Next()
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        i++;
        nextspaceship();
    }
    void nextspaceship()
    {
        Debug.Log(i);
        if (i == 0)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P1.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P1.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P1.hp.ToString();
            prev_button.SetActive(false);
            next_button.SetActive(true);
            S_1.SetActive(true);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (SAVETRY.P1.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P1.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P1.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 1)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P2.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P2.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P2.hp.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(true);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (SAVETRY.P2.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P2.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P2.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 2)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P3.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P3.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P3.hp.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(true);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (SAVETRY.P3.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P3.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P3.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 3)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P4.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P4.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P4.hp.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(true);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (SAVETRY.P4.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P4.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P4.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 4)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P5.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P5.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P5.hp.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(true);
            S_6.SetActive(false);
            if (SAVETRY.P5.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P5.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P5.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 5)
        {
            Lvl_Spship.text = "Level:" + SAVETRY.P6.level.ToString();
            Dmg_Spship.text = "Damage:" + SAVETRY.P6.dmg.ToString();
            Hp_Spship.text = "Hp:" + SAVETRY.P6.hp.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(false);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(true);
            if (SAVETRY.P6.unlock)
            {
                buy_button.SetActive(false);
                Upgcost.text=SAVETRY.P6.Upgcost.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=SAVETRY.P6.Buycost.ToString();
                upgrade_button.SetActive(false);
            }
        }
    }
    public void Scrollbar_ChgSpship(int ivalue)
    {
        FindObjectOfType<AudioManager>().SfxPlay("Click");
        if(ivalue==0)
        {
            i=0;
        }
        else if(ivalue==1)
        {
            i=1;
        }
        else if(ivalue==2)
        {
            i=2;
        }
        else if(ivalue==3)
        {
            i=3;
        }
        else if(ivalue==4)
        {
            i=4;
        }
        else if(ivalue==5)
        {
            i=5;
        }
        nextspaceship();
    }
    /*
    void Upgraded()
    {
        if(j==0)
        {
            up.SetActive(false);
            down.SetActive(true);
            Upspaceship();
        }
        else if(j==1)
        {
            up.SetActive(true);
            down.SetActive(false);
            Downspaceship();
        }
    }
    void Downspaceship()
    {
        if(i==0)
        {
            S_1A.SetActive(true);
            S_2A.SetActive(false);
        }
        else if(i==1)
        {
            S_1D.SetActive(true);
            S_2D.SetActive(false);
        }
        else if(i==2)
        {
            S_1C.SetActive(true);
            S_2C.SetActive(false);
        }
    }
    void Upspaceship()
    {
        if(i==0)
        {
            S_1A.SetActive(false);
            S_2A.SetActive(true);
        }
        else if(i==1)
        {
            S_1D.SetActive(false);
            S_2D.SetActive(true);
        }
        else if(i==2)
        {
            S_1C.SetActive(false);
            S_2C.SetActive(true);
        }
    }
    */
}
