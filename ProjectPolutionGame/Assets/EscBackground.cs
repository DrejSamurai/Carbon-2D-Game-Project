using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscBackground : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pause;
    public AudioSource audioSource;


    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
           
            if (GameIsPaused)
            {
                ResumeButton();
            }
            else
            {
                Pause();
            }
        }

    }


    public void ResumeButton()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        audioSource.Play();
        
    }

    void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        audioSource.Pause();
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScreen");

    }
}
