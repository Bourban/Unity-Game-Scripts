using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPickupScript : MonoBehaviour
{

    public GameObject text;

    void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
                ScoreScript.iPlunder += 100;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.SetActive(false);
    }

}
