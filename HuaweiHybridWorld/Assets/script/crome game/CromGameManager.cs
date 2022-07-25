using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CromGameManager : MonoBehaviour
{
    public int cromScore;
    public GameObject gameOverCanvas;
    public Text cromScoreText;
    private void Start()
    {
        cromScore = 0;
        gameOverCanvas.SetActive(false);
    }
    private void Update()
    {
        cromScoreText.text = cromScore.ToString();
    }
    public void cromGameover()
    {
        //pause game
        Time.timeScale = 0;
        //show canvas
        gameOverCanvas.SetActive(true);
    }

    public void cromScoreInc()
    {
        cromScore++;
    }
    
    public void restartCromGame()
    {
        SceneManager.LoadScene("Shubham scene crom game");
    }
}
