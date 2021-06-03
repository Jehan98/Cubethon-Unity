using UnityEngine;

public class NextLevel : MonoBehaviour 
{ 
    public PlayerMovement playerMovement;

   private void LoadNextLevel(Collider other)
    {
        FindObjectOfType<GameManager>().NextLevel();
    }
}
