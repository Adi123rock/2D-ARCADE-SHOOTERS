using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLock : MonoBehaviour
{
    public GameObject L02_lock,L03_lock,L04_lock,L05_lock;
    // Start is called before the first frame update
    void Start()
    {
        LvlLock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LvlLock()
    {
        if(UIvarables.CompLvlno==1)
        {
            L02_lock.SetActive(false);
        }
        else if(UIvarables.CompLvlno==2)
        {
            L02_lock.SetActive(false);
            L03_lock.SetActive(false);
        }
        else if(UIvarables.CompLvlno==3)
        {
            L02_lock.SetActive(false);
            L03_lock.SetActive(false);
            L04_lock.SetActive(false);
        }
        else if(UIvarables.CompLvlno==4)
        {
            L02_lock.SetActive(false);
            L03_lock.SetActive(false);
            L04_lock.SetActive(false);
            L05_lock.SetActive(false);
        }
    }
}
