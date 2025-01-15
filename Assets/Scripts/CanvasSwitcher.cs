using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public Canvas canvas1; 
    public Canvas canvas2;

    public void SwitchToCanvas2() 
    {
        canvas1.enabled = false; 
        canvas2.enabled = true; 
    }
}
