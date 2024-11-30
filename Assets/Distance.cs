using UnityEngine;

public class Distance : MonoBehaviour
{
    Transform player;
    Text asd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find('Player').GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float Distance = player.position.x;
        asd.Text = str(Distance);
    }
}
