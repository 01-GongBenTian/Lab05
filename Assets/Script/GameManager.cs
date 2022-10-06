using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score;
    private static int TargetScore;
    public static int TimeLeft;


    // Start is called before the first frame update
    void Start()
    {
        TimeLeft = 40;

        Score = 0;
        TargetScore = 10 * GameObject.FindGameObjectsWithTag("Coin").Length;

        CountDown();
    }

    // Update is called once per frame
    void Update()
    {
        if(Score >= TargetScore)
        {
            SceneManager.LoadScene("GameWinScene");
        }

        if(TimeLeft <= 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }

    void CountDown()
    {
        TimeLeft -= 1;

        Invoke("CountDown", 1);
    }
}
