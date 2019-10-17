using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneShoot : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float bulletSpeed = 7.0f;
    public float bulletlifetime = 1.0f;
    public float shootDelay = 1.5f;
    float timer = 0;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootDelay)
        {
            timer = 0;

            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletlifetime);
        }
    }
}
