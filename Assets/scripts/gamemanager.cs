using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public GameObject LevelcompleteUI;
    public void Levelcomplete ()
    {
        LevelcompleteUI.SetActive(true);
    }
    public float Restartdelay=1f;
    public void Endgame ()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", Restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
