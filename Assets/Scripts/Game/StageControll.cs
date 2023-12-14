using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Debug.Log("stageClear");
            GameManager.Instance.NextStage();
        }
    }
}
