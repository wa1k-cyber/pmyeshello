using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enehealth : MonoBehaviour
{
    public int health = 3;
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health--;
            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
