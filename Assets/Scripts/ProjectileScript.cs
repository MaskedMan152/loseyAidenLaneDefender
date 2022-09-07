using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 9;
    public GameObject explodingEffect;
    public Transform thisPosition;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(explodingEffect, thisPosition.position, thisPosition.rotation);
        bullet.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explodingEffect, thisPosition.position, thisPosition.rotation);
        Destroy(gameObject);
    }

}
