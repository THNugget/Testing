using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * smoothSpeed);
    }
}
