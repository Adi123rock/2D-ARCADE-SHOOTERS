using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public int level;
    public int health;
    public float[] position;
    public Data (SAVETRY data)
    {
        level=data.P1.level;
        // level=spship_Details.LvlCompno;
    }
}
