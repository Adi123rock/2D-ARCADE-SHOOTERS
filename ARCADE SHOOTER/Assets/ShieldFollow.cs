using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldFollow : MonoBehaviour
{
    public Vector3 offset;//is created to destroy plybullet
    public static Transform player;
    public Transform player1;
    // Start is called before the first frame update
    void Start()
    {
        player=followplayer.player;
    }

    // Update is called once per frame
    void Update()
    {
        if(player==null)
        {
            Debug.Log("NULL");
            player=player1;
        }
        transform.position=player.position;
        
        /*
        Healthbar.position=player.position + Hoffset;
        Blackbar.position=player.position + Boffset+lshift;*/
    }
}
