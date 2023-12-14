using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float downSpeed = 50f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Gravity();
    }

    private void Gravity()
    {
        //StartCoroutine(PlayerGo());
    }

    IEnumerator PlayerGo()
    {
        while(true)
        {
            rb.velocity = Vector2.down * downSpeed * Time.deltaTime;
            yield return null;
        }
    }
}
