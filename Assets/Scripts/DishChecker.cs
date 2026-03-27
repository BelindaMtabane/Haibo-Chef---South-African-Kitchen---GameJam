using UnityEditor;
using UnityEngine;
public class DishChecker : MonoBehaviour
{
    public GameObject dishbutton;
    private void OnCollisionEnter(Collision collision)
    {
        //Check that the one near to the station is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            dishbutton.SetActive(true);

        }
    }
    public void SetPanelVisisblity()
    {
        dishbutton.SetActive(false);
    }

}
