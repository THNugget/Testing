using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    private bool canShoot = true;
    private float shootCooldown = 0.5f;
    //private Rigidbody2D rb;

    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}


    //private void Update()
    //{
    //    rb.linearVelocity = transform.right * bulletSpeed;
    //}

    private void Update()
    {
       shootCooldown -= Time.deltaTime;

        if (shootCooldown <= 0f)
         {
              canShoot = true;
        }
    }

    public void Shooting(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && canShoot)
        {
            canShoot = false;
            shootCooldown = 0.5f;
            GameObject BulletIns = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.up * bulletSpeed);
        }
    }
}
