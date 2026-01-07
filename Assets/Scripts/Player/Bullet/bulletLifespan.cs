using UnityEngine;

public class bulletLifespan : MonoBehaviour
{
    private float bulletAlive = 1.5f;
    // Update is called once per frame
    void Update()
    {
        bulletAlive -= Time.deltaTime;
        if (bulletAlive <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
