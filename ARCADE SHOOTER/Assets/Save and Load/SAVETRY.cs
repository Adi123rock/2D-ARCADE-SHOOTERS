using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAVETRY : MonoBehaviour
{
    public static player P1=new player(1,50,200,2500,2000,true),P2=new player(1,60,250,3000,2500,false),P3=new player(1,70,300,3500,3000,false),P4=new player(1,80,350,4000,3500,false),P5=new player(1,90,400,4500,4000,false),P6=new player(1,100,450,5000,4500,false);

    public player DP1=new player(1,50,200,2500,2000,true),DP2=new player(1,60,250,3000,2500,false),DP3=new player(1,70,300,3500,3000,false),DP4=new player(1,80,350,4000,3500,false),DP5=new player(1,90,400,4500,4000,false),DP6=new player(1,100,450,5000,4500,false);

    public player ply1=P1,ply2=P2,ply3=P3,ply4=P4,ply5=P5,ply6=P6;
    public int CompLvlno=UIvarables.CompLvlno;
    //public static Spship_class ship1A,ship2A; 
    public string namespaceship=UIvarables.namespaceship;
    public float coins=UIvarables.coins,diamonds=UIvarables.diamonds;
    public void Upd_details(){
        Debug.Log(P1.level);
    }
    public SAVETRY (SAVETRY data)
    {
        data=this;
        // level=data.P1.level;
        // level=spship_Details.LvlCompno;
    }
    
}
[System.Serializable]
public class player{
    public int level;
    public int hp;
    public int dmg;
    public int Upgcost;
    public int Buycost;
    public bool unlock;
    public player(int level,int dmg,int hp,int Upgcost,int Buycost,bool unlock){
        this.level=level;
        this.dmg=dmg;
        this.hp=hp;
        this.Upgcost=Upgcost;
        this.Buycost=Buycost;
        this.unlock=unlock;
    }
}
