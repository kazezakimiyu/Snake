using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

    private void LevelUp()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (Score.scoreValue >= 2)
            {
                Debug.Log("Level Up");
                SceneManager.LoadScene("Level2");
            }
        }
    }
}
