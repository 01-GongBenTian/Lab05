using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour
{
    [SerializeField]
    private Text ScoreDisplay;

    [SerializeField]
    private Text TimerDisplay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "  Score: " + GameManager.Score;
        TimerDisplay.text = string.Format("Timer: {0}  ", GameManager.TimeLeft);
    }
}
