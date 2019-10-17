using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletlifetime = 1.0f;
    public float shootDelay = 1.0f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timer > shootDelay)
        {
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mouseposition = Input.mousePosition;
            Debug.Log(mouseposition);
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            Debug.Log(mouseposition);
            Vector2 shootDir = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletlifetime);
        }
    }
}
