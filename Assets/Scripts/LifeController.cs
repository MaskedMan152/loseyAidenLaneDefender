using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeController : MonoBehaviour
{
    public int lives = 3;
    public GameObject gm;
    public TMP_Text myLifeAsText;
    public int score;
    public TMP_Text myScoreAsText;
    public int highScore;
    public TMP_Text myHighScoreAsText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        --lives;
    }

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        score = 0;
        int theHighScore = PlayerPrefs.GetInt("Highscore");
        highScore = theHighScore;
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("Highscore", highScore);
            PlayerPrefs.Save();
        }

        myLifeAsText.text = ("Lives: " + lives.ToString());
        myScoreAsText.text = ("Score: " + score.ToString());
        myHighScoreAsText.text = ("High Score: " + highScore.ToString());
        if (lives < 1)
        {
            gm.SetActive(true);
            lives = 3;
            score = 0;
        }
    }
}
