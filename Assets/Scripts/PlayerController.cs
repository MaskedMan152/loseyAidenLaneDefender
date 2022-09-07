/*****************************************************************************
// File Name :     
// Author :        Aiden J Losey 
// Creation Date : 8/25/22   
//
// Brief Description : This Script manages all aspects of the players control
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerPositionControler;
    public Transform playerPosition;
    public GameObject bullet;
    public bool canShoot = true;
    LifeController lc;


    // Start is called before the first frame update
    void Start()
    {
        var lifeThing = GameObject.Find("lifeThing");
        lc = lifeThing.GetComponent<LifeController>();
        playerPositionControler = 1;
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        float yMove = Input.GetAxis("Vertical");

        Vector3 newPos = transform.position;

        newPos.y += yMove * Time.deltaTime * 7;

        newPos.y = Mathf.Clamp(newPos.y, -3.7f, 3.7f);

        transform.position = newPos;

        if (Input.GetKey(KeyCode.Space) && (canShoot))
        {
            Instantiate(bullet, playerPosition.position, playerPosition.rotation);
            canShoot = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("enemy"))
        {
            lc.lives--;
        }
    }

    IEnumerator Shoot()
    {
        while (true)
        {
           canShoot = true;
           yield return new WaitForSeconds(0.5f);
        }
    }
        
}
