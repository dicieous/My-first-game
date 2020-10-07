using UnityEngine;
using UnityEngine.SceneManagement;

public class welcome : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
