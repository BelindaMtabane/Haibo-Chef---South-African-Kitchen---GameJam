using UnityEngine;

public class ButtonPressor : MonoBehaviour
{
    public CuttingSystems cuttingSystems;
    public StirringSystem stirringSystem;
    public void OnButtonPressedCut()
    {
        cuttingSystems.CheckButton(gameObject);
    }
    public void OnButtonPressedStir()
    {
        stirringSystem.CheckButton(gameObject);
    }
}
