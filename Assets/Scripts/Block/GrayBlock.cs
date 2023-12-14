using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayBlock : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
