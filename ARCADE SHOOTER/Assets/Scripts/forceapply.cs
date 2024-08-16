using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class forceapply : MonoBehaviour
{
    //bool Fwd=true;
    //public Vector3 explosionPosition;
    // public float ply_vel=6f;
    public float fwdForce=20f;
    public float sideForce=100f;
    public Rigidbody2D rb;
    // bool up_down;
    // Start is called before the first frame update
    void Start()
    {

    }
     void FixedUpdate()
    {
        
        if(Input.GetKey("w") ){
            rb.AddForce(new Vector2(0,fwdForce*Time.deltaTime));
        }
        else if(Input.GetKey("s") ){
            rb.AddForce(new Vector2(0,-fwdForce*Time.deltaTime));
        }
        //rb.AddExplosionForce(20,explosionPosition,2);
        if(Input.GetKey("d")){
            rb.AddForce(new Vector2(sideForce*Time.deltaTime,0));
        }
        else if(Input.GetKey("a")){
            rb.AddForce(new Vector2(-sideForce*Time.deltaTime,0));
        }
        
    }

    
    // void FixedUpdate()
    // {   
    //     if(Input.GetKey("a") ){
    //         // rb.AddForce(new Vector2(0,fwdForce*Time.deltaTime));
    //         rb.velocity=new Vector2(-ply_vel,0);
    //         up_down=false;
    //     }
    //     else if(Input.GetKey("d")){
    //         // rb.AddForce(new Vector2(0,-fwdForce*Time.deltaTime));
    //         rb.velocity=new Vector2(ply_vel,0);
    //         up_down=false;
    //     }
    //     else
    //     {
    //         rb.velocity=new Vector2(0,0);
    //         up_down=false;
    //     }
    //     if(Input.GetKey("w") && up_down){
    //         // rb.AddForce(new Vector2(sideForce*Time.deltaTime,0));
    //         rb.velocity=new Vector2(0,ply_vel);
    //     }
    //     else if(Input.GetKey("s") && up_down){
    //         // rb.AddForce(new Vector2(-sideForce*Time.deltaTime,0));
    //         rb.velocity=new Vector2(0,-ply_vel);
    //     }
    //     else
    //     {
    //         rb.velocity=new Vector2(0,0);
    //     }
        
    // }
}
