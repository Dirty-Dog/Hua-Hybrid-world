using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CromGameManager : MonoBehaviour
{
    public int cromScore;
    public GameObject gameOverCanvas;
    private void Start()
    {
        cromScore = 0;
        gameOverCanvas.SetActive(false);
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
    
    void restartCromGame()
    {
        SceneManager.LoadScene("Shubham scene crom game");
    }
}
