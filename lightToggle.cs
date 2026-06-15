using UnityEngine;

public class LightToggle : MonoBehaviour
{
    public Light roomLight;

    public void ToggleLight()
    {
        roomLight.enabled = !roomLight.enabled;
    }
}