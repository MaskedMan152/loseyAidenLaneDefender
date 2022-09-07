using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject dies;
    // Update is called once per frame
    void Update()
    {
        //SCREW YOU UNITY
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dies.SetActive(false);
        }
    }
}
