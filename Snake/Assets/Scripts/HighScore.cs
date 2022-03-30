using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int highValue = 0;
    Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = GetComponent<Text>();
        highValue = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.scoreValue >= highValue)
        {
            highValue = Score.scoreValue;
            highScore.text = "Highest Score: " + highValue;
            PlayerPrefs.SetInt("HighScore", highValue);
        }
        else
        {
            highScore.text = "Highest Score: " + highValue;
        }
    }
}
