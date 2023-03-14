using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicText : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore() {
        playerScore = playerScore + 1 ;
        scoreText.text = playerScore.ToString();
    }
}
