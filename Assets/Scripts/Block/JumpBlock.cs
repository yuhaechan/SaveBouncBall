using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            rb = other.GetComponent<Rigidbody2D>();
            //rb.AddForce(new Vector2(0, 30f), ForceMode2D.Force);
            rb.velocity = new Vector2(rb.velocity.x, 15f);
        }
    }
}
