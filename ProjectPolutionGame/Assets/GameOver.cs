using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Vector2 firstCheckpointPos;
    private GameMaster gm;
    
    public Player player;
    public void Setup()
    {
        gameObject.SetActive(true);
        
    }


    public void RestartButton()
    {
        Time.timeScale = 1;
        player.transform.position = firstCheckpointPos;
        gameObject.SetActive(false);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScreen");

    }
}
