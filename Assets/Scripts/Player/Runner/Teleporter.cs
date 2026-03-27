using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player end Runner");
            SceneManager.LoadScene("MainResturant");
        }
    }
}
