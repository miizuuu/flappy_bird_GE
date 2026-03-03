using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool isStarted = false;
    
    void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") &&  !isStarted)
        {
            StartScreen.SetActive(false);
            isStarted = true;
            Time.timeScale = 1f;
        }
    }
}
