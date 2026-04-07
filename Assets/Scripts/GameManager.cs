using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject GameOverScreen;
    private bool isStarted = false, gameOver = false;
    
    void Awake()
    {
        Instance = this;
        StartScreen.SetActive(true);
        GameOverScreen.SetActive(false);
        Time.timeScale = 0f;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetButtonDown("Fire1") && !isStarted)
            {
                StartScreen.SetActive(false);
                isStarted = true;
                Time.timeScale = 1f;
            }
        }
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        gameOver = true;
        AudioManager.Instance.PlayDieSound();
    }
    
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
