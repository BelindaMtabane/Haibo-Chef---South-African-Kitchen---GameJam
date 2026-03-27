using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StirringSystem : MonoBehaviour
{
    DishInfor DishInfor;
    private void OnCollisionEnter(Collision collision)
    {
        if (DishInfor != null) return;
        //Check that the one near to the station is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Runner");
        }
    }

}
