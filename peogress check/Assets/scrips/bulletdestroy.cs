using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
