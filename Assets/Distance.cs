using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    Transform player;
    public Text asd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    
    }

    // Update is called once per frame
    void Update()
    {
        float Distance = MathF.Round(player.position.x) + 20;
        asd.text = "Distance:" + Distance.ToString();
    }
}
