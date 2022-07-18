using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FapBirdGameManager : MonoBehaviour
{
    public int score;
    public int life;
    public GameObject gameoverScreen;
    public Text Score_;
    private void Start()
    {
        score = 0;
        Time.timeScale = 1;
        gameoverScreen.SetActive(false);
    }
    private void Update()
    {
        Score_.text = score.ToString();
    }
    public void gameOver()
    {
        //pause game
        Time.timeScale = 0;
        //show score
        gameoverScreen.SetActive(true);

    }
    public void scoreInc()
    {
        score++;
    }
    public void lifeInc()
    {
        life++;
    }
    public void lifeDec()
    {
        life--;
    }

    public void restart()
    {
        SceneManager.LoadScene("shubham scene");
    }
}
