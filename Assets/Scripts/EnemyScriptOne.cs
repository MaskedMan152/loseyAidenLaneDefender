using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptOne : MonoBehaviour
{
    public Rigidbody2D enemyOne;
    LifeController lc;

    // Start is called before the first frame update
    void Start()
    {
        var lifeThing = GameObject.Find("lifeThing");
        lc = lifeThing.GetComponent<LifeController>();
        enemyOne.velocity = transform.right * -3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lc.score+= 100;
        enemyOne.velocity = transform.right * 0;
        GetComponent<Animator>().SetTrigger("BrainDead");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public void Dies()
    {
        Destroy(gameObject);
    }
}
