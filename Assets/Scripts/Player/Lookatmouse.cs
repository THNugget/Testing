using UnityEngine;

public class Lookatmouse : MonoBehaviour
{
    private Camera cam;

    private PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.canMove)
        {
        Vector3 mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        float angleRad = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
        float angleDeg = (180 / Mathf.PI) * angleRad - 90; //Offset by 90 degrees

        transform.rotation = Quaternion.Euler(0f, 0f, angleDeg);
        //Debug.DrawLine(transform.position, mousePos, Color.white, Time.deltaTime);
            
        }
    }
}
