using UnityEngine;
using UnityEngine.SceneManagement;


public class UIHandler : MonoBehaviour
{
    public void RestartGame()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
