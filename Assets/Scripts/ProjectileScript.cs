using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 9;

    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
