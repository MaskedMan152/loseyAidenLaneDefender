using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptThree : MonoBehaviour
{
    public Rigidbody2D enemyThree;
    public int health = 5;
    public bool shot = false;
    LifeController lc;

    // Start is called before the first frame update
    void Start()
    {
        var lifeThing = GameObject.Find("lifeThing");
        lc = lifeThing.GetComponent<LifeController>();
        enemyThree.velocity = transform.right * -1;
        StartCoroutine(Shot());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            shot = true;
            --health;
        GetComponent<Animator>().SetTrigger("BrainDead3");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


    IEnumerator Shot()
    {
        while (true)
        {
            if (shot == true)
            {
                enemyThree.velocity = transform.right * 0;
                yield return new WaitForSeconds(0.5f);
                shot = false;
                enemyThree.velocity = transform.right * -2;
            }
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void Dies3()
    {
        if (health < 1)
        {
            lc.score += 500;
            Destroy(gameObject);
        }
        GetComponent<Animator>().SetTrigger("BackToNormal2");
    }
}