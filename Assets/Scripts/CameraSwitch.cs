using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{
    public Camera[] cameras;
    private int current = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
            cameras[i].enabled = (i == 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            cameras[current].enabled = false;
            current++;              

            if (current >= cameras.Length)      
            {
                current = 0;                   
            }

            cameras[current].enabled = true;
        }
    }
}
