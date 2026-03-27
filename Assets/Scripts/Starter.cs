using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main Resturant");
    }
    public void exit()
    {
        Application.Quit();
    }
}
