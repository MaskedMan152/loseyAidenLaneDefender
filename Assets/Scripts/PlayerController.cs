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


    // Start is called before the first frame update
    void Start()
    {
        playerPositionControler = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float yMove = Input.GetAxis("Vertical");

        Vector3 newPos = transform.position;

        newPos.y += yMove * Time.deltaTime * 7;

        newPos.y = Mathf.Clamp(newPos.y, -2.7f, 3.4f);

        transform.position = newPos;

        
    }

   /* IEnumerator PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerPositionControler++;
            if (playerPositionControler > 6)
            {
                playerPositionControler = 6;
            }
            Debug.Log(playerPositionControler);
            yield return new WaitForSeconds(0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerPositionControler--;
            if (playerPositionControler < 1)
            {
                playerPositionControler = 1;
            }
            Debug.Log(playerPositionControler);
            yield return new WaitForSeconds(0.1f);
        }
        }*/
        
}
