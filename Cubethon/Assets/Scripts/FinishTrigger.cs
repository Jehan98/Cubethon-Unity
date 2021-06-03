using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnTriggerEnter(Collider other)
    {
        playerMovement.enabled = false;
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
