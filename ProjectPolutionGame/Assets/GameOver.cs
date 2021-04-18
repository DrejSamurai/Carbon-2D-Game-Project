using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Vector2 firstCheckpointPos;
    private GameMaster gm;
    public void Setup()
    {
        gameObject.SetActive(true);
    }


    public void RestartButton()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene("GameLevel1");
        //Application.LoadLevel(Application.loadedLevel);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScreen");

    }
}
