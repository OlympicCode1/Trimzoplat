using Unity.VisualScripting;
using UnityEngine;

public class Log : MonoBehaviour
{
    public float speed;

    Transform player;
    bool riding = false;

    void Start()
    {
        
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if (riding == false)
        {
            transform.position += new Vector3(-speed,0,0) * Time.deltaTime;
        }
        else
        {
            transform.position += new Vector3(-speed * 0.7f,0,0) * Time.deltaTime;
        }
       
        if (Vector2.Distance(player.position , transform.position) >= 45)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision )
    {
        if (collision.CompareTag("Player"))
        {
            riding = true;
            collision.transform.SetParent(transform);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
            riding = false;
        }
    }
}
