using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle_scr : MonoBehaviour
{
    public float restartDelay = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        // Disable control keys
        Input.ResetInputAxes();
        Input.GetKeyDown(KeyCode.UpArrow);
        Input.GetKeyDown(KeyCode.DownArrow);
        Input.GetKeyDown(KeyCode.RightArrow);
        Input.GetKeyDown(KeyCode.LeftArrow);
        Input.GetKeyDown(KeyCode.W);
        Input.GetKeyDown(KeyCode.A);
        Input.GetKeyDown(KeyCode.D);

        // Restart level after a delay
        Invoke("RestartLevel", restartDelay);
    }
    

    private void RestartLevel()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
