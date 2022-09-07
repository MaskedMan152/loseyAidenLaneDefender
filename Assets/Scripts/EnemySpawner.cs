using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int enemyType;
    public GameObject oneHealthEnemy;
    public GameObject threeHealthEnemy;
    public GameObject fiveHealthEnemy;
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawn());
    }
   
    IEnumerator Spawn()
    {
        while (true)
        {
            enemyType = Random.Range(1,4);
            if(enemyType == 1)
            {
                Instantiate(oneHealthEnemy, spawnPoint.position, spawnPoint.rotation);
            }
            else if(enemyType == 2)
            {
                Instantiate(threeHealthEnemy, spawnPoint.position, spawnPoint.rotation);
            }
            else
            {
                Instantiate(fiveHealthEnemy, spawnPoint.position, spawnPoint.rotation);
            }
            yield return new WaitForSeconds(Random.Range(4, 10));
        }
    }
}
