using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject StartScreen;
    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject GameOverScreen;
    private bool isInitial = false;

    private void Awake()
    {
        Instance = this;

        StartScreen.SetActive(true);
        GameOverScreen.SetActive(false);

        restartButton.onClick.AddListener(RestartGame);
        Time.timeScale = 0f;

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && isInitial == false)
        {
            StartScreen.SetActive(false);
            isInitial = true;
            Time.timeScale = 1f;
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;

    }

}
