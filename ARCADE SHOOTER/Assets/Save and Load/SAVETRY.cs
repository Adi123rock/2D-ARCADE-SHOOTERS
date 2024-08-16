using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAVETRY : MonoBehaviour
{
    public  player P1,P2,P3,P4,P5,P6;
    public void Upd_details(){
        Debug.Log(P1.level);
    }
}
[System.Serializable]
public class player{
    public int level;
    public int hp;
    public int dmg;
}
