using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Enviroment : MonoBehaviour
{
    public Transform player;
    public GameObject river;

    public GameObject[] Rivers;

    void Start()
    {
        
        
        
    
        
    }
    void Update()
    {
        print(Mathf.RoundToInt(player.position.x/30));




    }
    void addRiver()
    
    { 
        GameObject existingriver = Instantiate(river);
        Rivers[0] = existingriver;
    }
}
