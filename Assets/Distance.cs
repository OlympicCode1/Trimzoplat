using TMPro;
using UnityEngine;

public class Distance : MonoBehaviour
{
    Transform player;
    TextMeshPro asd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        asd = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        float Distance = player.position.x;
        asd.text = Distance.ToString();
    }
}
