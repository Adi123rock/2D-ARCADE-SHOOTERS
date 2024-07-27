using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderbd : MonoBehaviour
{
    //Transform rowchild;
    public Transform row,container;
    public GameObject ldbd_panel;
    //Transform row2;
    // Start is called before the first frame update
    // private void Awake()
    // {
    //     //container=transform.Find("Data");
    //     //row=container.Find("ScoreEntry");
    //     float templateHeight=20f;
    //     //row.gameObject.SetActive(false);
    //     for(int i=0;i<10;i++)
    //     {
    //         // Transform entryTransform=Instantiate(row,container);
    //         // RectTransform entryRectTransform=entryTransform.GetComponent<RectTransform>();
    //         // entryRectTransform.anchoredPosition=new Vector2(0,-templateHeight*i);
    //         // entryTransform.gameObject.SetActive(true);
    //         row2=Instantiate(row,container);
    //         //row2.Find("Name_Text(TMP)").GetComponent<Text>().text="Aditya the god";
    //         row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*2);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Leaderboard()
    {
        //float templateHeight=20f;
        ldbd_panel.SetActive(true);
        // row2=Instantiate(row,container);
        // row2.Find("Name_Text(TMP)").GetComponent<Text>().text="Aditya the god";
        // row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*2);
        // row2.Find("Name_Text").GetComponent<Text>().text="Aditya the god";
        //row2.transform.position=row.transform.position;
        for(int i=0;i<5;i++)
        {
           
            Transform row2=Instantiate(row,container);
            //row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*i);
            //Transform rowchild=row2.GetChild(0);
            //rowchild.GetComponent<Text>().text="Aditya the god";
        }
        
    }
}
