using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Vector2 firstCheckpointPos;
    private GameMaster gm;
    public AudioSource music;
    public AudioSource music2;
    public Player player;
    public void Setup()
    {
        gameObject.SetActive(true);
        music.Stop();
        music2.Play();
    }


    public void RestartButton()
    {
        Time.timeScale = 1;
        player.transform.position = firstCheckpointPos;
        gameObject.SetActive(false);
        music2.Pause();
        music.Play();
        
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScreen");

    }
}
