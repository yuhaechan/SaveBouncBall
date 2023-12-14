using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleryL : MonoBehaviour
{

    private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            rb = other.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(-80f, 0), ForceMode2D.Impulse);
        }
    }
}
