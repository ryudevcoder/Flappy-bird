using System;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool isInitial = false;
    private void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && isInitial==false)
        {
            StartScreen.SetActive(false);
            isInitial = true;
            Time.timeScale = 1f;
        }
    }
}
