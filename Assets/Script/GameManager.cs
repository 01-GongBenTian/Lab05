using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score;
    private static int TargetScore;


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        TargetScore = 10 * GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(Score >= TargetScore)
        {
            SceneManager.LoadScene("GameWinScene");
        }
    }
}
