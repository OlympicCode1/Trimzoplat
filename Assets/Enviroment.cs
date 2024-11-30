using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Enviroment : MonoBehaviour
{
    public Transform player;
    public GameObject river;
    public GameObject[] Items;
    public int[] putRivers;
    public float ItemFrequency;
    float Timer;
    
    
    void Start()
    {
        
        addRiver(0);
        addRiver(1);
    }
    void Update()
    {
    //River
        //gets player x on 30 by 30 grid
        int playerPos = Mathf.RoundToInt(player.position.x/30);


        for(int i = putRivers.Length; i > 0; i--)
        {
          
           
            if(!putRivers.Contains(playerPos + (i - 2)) && (playerPos + (i - 2)) >= 0)
            {
                addRiver(playerPos + i - 2);
                putRivers[i-1] = playerPos + i - 2;
            }
        }
    //

    //Items
    float randTime = UnityEngine.Random.Range(-1,3);
    
    Timer += randTime * Time.deltaTime;
    
    if(Timer >= ItemFrequency)
    {
        //Random number for which Item
        int itemId = UnityEngine.Random.Range(0,Items.Length);
        print(itemId);
        if (Items[itemId] != null)
        {
            GameObject item = Instantiate(Items[itemId]);
            item.transform.position = new Vector2(player.position.x + 35,0.5f);
        }
       Timer = 0;
        
    }
       
        
    
    }


    void addRiver(int cordX)
    { 
        GameObject existingriver = Instantiate(river);
        existingriver.GetComponent<Transform>().position = new Vector2(cordX * 30,0);
       
    }
}
