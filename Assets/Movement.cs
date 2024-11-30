using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    Rigidbody2D rb;
    public Transform feet;
    public LayerMask ground;
    public float feetRadius;
    public float Acceleration;
    public float speedCap;
    public float jump;
    float originalGravity;
    public float fallingGravity;

    public float maxJumps;
    float jumps;
    bool grounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalGravity = rb.gravityScale;
    }

    void Update()
    {
        if (rb.linearVelocityY < 0)
        {
            rb.gravityScale = fallingGravity;
        }
        else
        {
             rb.gravityScale = originalGravity;
        }




        float dir = Input.GetAxisRaw("Horizontal");
        //Calculate used speed by subtracting how much faster the character is going than speed cap. 
        float  usedSpeed = (Acceleration - Mathf.Clamp(Mathf.Abs(rb.linearVelocityX) - speedCap,0,Acceleration)) * dir;


        
        grounded = Physics2D.CircleCast(feet.position,feetRadius,new Vector2(0,0),10000000,ground);
        if (grounded == true && rb.linearVelocityY < 0)
        {
            jumps = maxJumps;
        }
        print(jumps);


        rb.linearVelocity += new Vector2(usedSpeed * Time.deltaTime,0);
        if (Input.GetKeyDown(KeyCode.Space) && jumps != 0)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocityX, jump);
                jumps -= 1;
            }

        
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(feet.position,feetRadius);
    }
}
    