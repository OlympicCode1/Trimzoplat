using UnityEngine;

public class River : MonoBehaviour
{
    Transform player;

    void Start()
    {
        
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if (Vector2.Distance(player.position , transform.position) >= 75)
        {
            Destroy(gameObject);
        }
    }
}
