using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT : MonoBehaviour
{

    public string sceneToLoad;
    
   




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene(sceneToLoad);
            
        }
    }

}
