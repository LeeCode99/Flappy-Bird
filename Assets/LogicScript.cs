using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public AudioSource scored3;
    private static bool checker = false;

    private void scoredNoiseFunc()
    {
        scored3.Play();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        scoredNoiseFunc();
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameStartScreen.SetActive(false);
        checker = true;
    }

    public void gameOver()
    {
        if (checker)
            gameOverScreen.SetActive(true);
    }

    public void gameStart()
    {
        gameStartScreen.SetActive(true);   
    }
}
