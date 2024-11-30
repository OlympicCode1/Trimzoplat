using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    Transform player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.position , transform.position) >= 3)
        {
            transform.position += new Vector3(player.position.x - transform.position.x,0,0) * speed * Time.deltaTime;
        }
    }
}
