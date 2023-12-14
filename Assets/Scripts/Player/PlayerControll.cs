using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    //[SerializeField] GameObject Player;

    private float speed = 0f;
    private float jumpPower = 10f;
    private float max_X_Move_Speed = 8.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    private void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > (Screen.width / 2))
                {
                    if (max_X_Move_Speed > speed)
                    {
                        speed += 8f;
                    }
                    //Debug.Log("right");
                    rb.velocity += new Vector2(speed * Time.deltaTime, 0);
                    //rb.AddForce(new Vector2(1f, 0), ForceMode2D.Impulse);
                    rb.AddForce(new Vector2(speed, 0), ForceMode2D.Force);


                }
                else
                {
                    if (-max_X_Move_Speed < speed)
                    {
                        speed -= 8f;
                    }
                    //Debug.Log("left");
                    rb.velocity += new Vector2(speed * Time.deltaTime, 0);
                    //rb.AddForce(new Vector2(-1f, 0), ForceMode2D.Impulse);
                    rb.AddForce(new Vector2(speed, 0), ForceMode2D.Force);

                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" || other.tag == "Block0")
        {
            Jump();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Angle();
    }

    void Jump()
    {
        //Debug.Log("jump");
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        //rb.AddForce(new Vector2(0, jumpPower) * jumpPower);
    }

    void Angle()
    {
        Debug.Log("Angle");
    }


}
