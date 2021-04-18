using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameMaster>();
        transform.position = gm.lastCheckPointPosition;
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
