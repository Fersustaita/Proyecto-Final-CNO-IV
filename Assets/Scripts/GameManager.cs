using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    private int score;
    public bool isGameActive = true;
    public float timeLeft;

    // Update is called once per frame
    void Update()
    {
        if (isGameActive) {
            timeLeft += Time.deltaTime;
            timerText.SetText("Time: " + Mathf.Round(timeLeft));
        }
    }

    // Update score with value from target clicked
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: "+score;
    }
}
