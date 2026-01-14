using UnityEngine;

public class BulletDeath : MonoBehaviour
{
    public ParticleSystem deathEffect;

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    Debug.Log(collision.gameObject.layer);
    //    if (collision.gameObject.layer == whatIsSolid)
    //    {
    //        Debug.Log("B");
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Wall") || collision.gameObject.layer == LayerMask.NameToLayer("Enemy") || collision.gameObject.layer == LayerMask.NameToLayer("Interactable"))
        {
            Destroy(gameObject);
        }
    }
}

