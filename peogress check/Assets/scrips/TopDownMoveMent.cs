using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMoveMent : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z;
        transform.up = mousePosition - transform.position;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 moveDir = y * transform.up + x * transform.right;
        moveDir.Normalize();
        GetComponent<Rigidbody2D>().velocity = moveDir;
    }
}
