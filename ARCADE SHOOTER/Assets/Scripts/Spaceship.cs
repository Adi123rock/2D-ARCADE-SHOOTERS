using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    SAVETRY save;
    public TextMeshProUGUI Buycost,Upgcost;
    public TextMeshProUGUI Lvl_Spship, Hp_Spship, Dmg_Spship;
    public GameObject buy_button, upgrade_button;
    public GameObject next_button, prev_button, S_1, S_2, S_3, S_4, S_5, S_6;
    int i = 0;
    void Start()
    {
        // save.P1.level=2;
        nextspaceship();
    }
    public void BuySpacship()
    {
        if (S_2.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Buycost_S2 && UIvarables.CompLvlno>1)
            {
                UIvarables.coins-=Spship_details.Buycost_S2;
                Spship_details.S2=true;
                // FindObjectOfType<SAVETRY>().
                
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<Spship_details.Buycost_S2)
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
            if(UIvarables.coins>Spship_details.Buycost_S3 && UIvarables.CompLvlno>2)
            {
                UIvarables.coins-=Spship_details.Buycost_S3;
                Spship_details.S3=true;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<Spship_details.Buycost_S3)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 3");
                }
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Buycost_S4 && UIvarables.CompLvlno>3)
            {
                UIvarables.coins-=Spship_details.Buycost_S4;
                Spship_details.S4=true;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                if(UIvarables.coins<Spship_details.Buycost_S4)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 4");
                }
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Buycost_S5 && UIvarables.CompLvlno>4)
            {
                UIvarables.coins-=Spship_details.Buycost_S5;
                Spship_details.S5=true;
            }
            else 
            {
                if(UIvarables.coins<Spship_details.Buycost_S5)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 5");
                }
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Buycost_S6 && UIvarables.CompLvlno>5)
            {
                UIvarables.coins-=Spship_details.Buycost_S6;
                Spship_details.S6=true;
            }
            else 
            {
                if(UIvarables.coins<Spship_details.Buycost_S6)
                {
                    Debug.LogError("MORE MONEY REQUIRED");
                }
                else
                {
                    Debug.LogError("Complete Lvl 6");
                }
            }
        }
        nextspaceship();
    }
    public void UpgSpacship()
    {
        if (S_1.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S1 && Spship_details.S1)
            {
                UIvarables.coins-=Spship_details.Upgcost_S1;
                Spship_details.Upgcost_S1+=500;
                Spship_details.Lvl_S1+=1;
                Spship_details.dmg_S1+=10;
                Spship_details.Hp_S1+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
                // Upgcost.text=Spship_details.Upgcost_S1.ToString();
                
            }
            else
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_2.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S2 && Spship_details.S2)
            {
                UIvarables.coins-=Spship_details.Upgcost_S2;
                Spship_details.Upgcost_S2+=500;
                Spship_details.Lvl_S2+=1;
                Spship_details.dmg_S2+=10;
                Spship_details.Hp_S2+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_3.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S3 && Spship_details.S3)
            {
                UIvarables.coins-=Spship_details.Upgcost_S3;
                Spship_details.Upgcost_S3+=500;
                Spship_details.Lvl_S3+=1;
                Spship_details.dmg_S3+=10;
                Spship_details.Hp_S3+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S4 && Spship_details.S4)
            {
                UIvarables.coins-=Spship_details.Upgcost_S4;
                Spship_details.Upgcost_S4+=500;
                Spship_details.Lvl_S4+=1;
                Spship_details.dmg_S4+=10;
                Spship_details.Hp_S4+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S5 && Spship_details.S5)
            {
                UIvarables.coins-=Spship_details.Upgcost_S5;
                Spship_details.Upgcost_S5+=500;
                Spship_details.Lvl_S5+=1;
                Spship_details.dmg_S5+=10;
                Spship_details.Hp_S5+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
            }
            else 
            {
                Debug.LogError("YOU CANNOT UPGRADE");
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if(UIvarables.coins>Spship_details.Upgcost_S6 && Spship_details.S6)
            {
                UIvarables.coins-=Spship_details.Upgcost_S6;
                Spship_details.Upgcost_S6+=500;
                Spship_details.Lvl_S6+=1;
                Spship_details.dmg_S6+=10;
                Spship_details.Hp_S6+=50;
                FindObjectOfType<AudioManager>().SfxPlay("Coin_Sound");
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
            if (Spship_details.S2)
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
            if (Spship_details.S3)
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
            if (Spship_details.S4)
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
            if (Spship_details.S5)
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
            if (Spship_details.S6)
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
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S1.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S1.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S1.ToString();
            prev_button.SetActive(false);
            next_button.SetActive(true);
            S_1.SetActive(true);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (Spship_details.S1)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S1.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S1.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 1)
        {
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S2.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S2.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S2.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(true);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (Spship_details.S2)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S2.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S2.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 2)
        {
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S3.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S3.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S3.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(true);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (Spship_details.S3)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S3.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S3.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 3)
        {
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S4.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S4.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S4.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(true);
            S_5.SetActive(false);
            S_6.SetActive(false);
            if (Spship_details.S4)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S4.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S4.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 4)
        {
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S5.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S5.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S5.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(true);
            S_6.SetActive(false);
            if (Spship_details.S5)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S5.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S5.ToString();
                upgrade_button.SetActive(false);
            }
        }
        else if (i == 5)
        {
            Lvl_Spship.text = "Level:" + Spship_details.Lvl_S6.ToString();
            Dmg_Spship.text = "Damage:" + Spship_details.dmg_S6.ToString();
            Hp_Spship.text = "Hp:" + Spship_details.Hp_S6.ToString();
            prev_button.SetActive(true);
            next_button.SetActive(false);
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(true);
            if (Spship_details.S6)
            {
                buy_button.SetActive(false);
                Upgcost.text=Spship_details.Upgcost_S6.ToString();
                upgrade_button.SetActive(true);
            }
            else
            {
                buy_button.SetActive(true);
                Buycost.text=Spship_details.Buycost_S6.ToString();
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
