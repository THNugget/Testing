using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEditor.PackageManager;

public class Light : MonoBehaviour
{
    public Light2D light2D;
    private float currentTime = 1f;
    public KeypadNumenter keypadNumenter;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0f)
        {
            light2D.enabled = !light2D.enabled;
            currentTime = 1f;
        }
        if (keypadNumenter.complete == true)
        {
            light2D.color = Color.green;
        }
        

    }
}
