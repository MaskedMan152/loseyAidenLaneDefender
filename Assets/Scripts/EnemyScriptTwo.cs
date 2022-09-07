using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptTwo : MonoBehaviour
{
    public Rigidbody2D enemyTwo;
    public int health = 3;
    public bool shot = false;
    LifeController lc;

    // Start is called before the first frame update
    void Start()
    {
        var lifeThing = GameObject.Find("lifeThing");
        lc = lifeThing.GetComponent<LifeController>();
        enemyTwo.velocity = transform.right * -2;
        StartCoroutine(Shot());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            shot = true;
            --health;
        GetComponent<Animator>().SetTrigger("BrainDead2");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    IEnumerator Shot()
    {
        while (true)
        {
            if(shot == true)
            {
                enemyTwo.velocity = transform.right * 0;
                yield return new WaitForSeconds(0.5f);
                shot = false;
                enemyTwo.velocity = transform.right * -2;
            }
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void Dies2()
    {
        if (health < 1)
        {
            lc.score += 250;
            Destroy(gameObject);
        }
        GetComponent<Animator>().SetTrigger("BackToNormal");
    }

}
