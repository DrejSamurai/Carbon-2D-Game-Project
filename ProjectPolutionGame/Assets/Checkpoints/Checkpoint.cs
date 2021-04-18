using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public Vector2 firstCheckPointPostion;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("CheckPointTriggred!");
            gm.lastCheckPointPosition = transform.position;
            gm.firstCheckPointPosition = firstCheckPointPostion;

        }
    }
}