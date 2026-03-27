using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainResturant");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void Home()
    {
        SceneManager.LoadScene("Begins");
    }
}
