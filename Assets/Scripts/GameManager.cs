using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public TextMeshProUGUI finalScoreText;

    public void GameOver()
    {
        gameOverUI.SetActive(true);

        finalScoreText.text = "GAME OVER\nFinal Score: " + ScoreManager.score + "\nPress R to Restart";

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
} 