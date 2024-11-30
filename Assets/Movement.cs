using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    public float speed;
    public float jump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dir = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(dir * speed * Time.deltaTime,rb.linearVelocityY);
        if (Input.GetButtonDown("Jump")){print("a");}
    }
}
