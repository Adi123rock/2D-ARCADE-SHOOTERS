using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    public player P1,P2,P3,P4,P5,P6;
    public int CompLvlno;
    public string namespaceship;
    public float coins,diamonds;
    // public int level;
    // public int health;
    // public float[] position;
    public Data (SAVETRY data)
    {
        this.P1=data.ply1;
        this.P2=data.ply2;
        this.P3=data.ply3;
        this.P4=data.ply4;
        this.P5=data.ply5;
        this.P6=data.ply6;
        this.namespaceship=data.namespaceship;
        this.coins=data.coins;
        this.diamonds=data.diamonds;
        this.CompLvlno=data.CompLvlno;

        // level=data.P1.level;
        // level=spship_Details.LvlCompno;
    }
    public Data (SAVETRY data,string a)
    {
        this.P1=data.DP1;
        this.P2=data.DP2;
        this.P3=data.DP3;
        this.P4=data.DP4;
        this.P5=data.DP5;
        this.P6=data.DP6;
        this.namespaceship="S_1";
        this.coins=17000;
        this.diamonds=10;
        this.CompLvlno=0;

        // level=data.P1.level;
        // level=spship_Details.LvlCompno;
    }
}
