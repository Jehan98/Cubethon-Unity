using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public float Delay = 0f;
    public bool GameOver = false;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (GameOver == false)                 //to avoid calling this method multiple time
        {
            GameOver = true;
            Invoke("Restart", 5f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }
    


}
