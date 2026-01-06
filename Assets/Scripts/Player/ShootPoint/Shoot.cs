using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletTransform;
    private bool canShoot = true;
    public float shootCooldown = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootBullet(InputAction.CallbackContext ctx)
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(bulletPrefab, bulletTransform.position, Quaternion.identity);
        }
    }
}
