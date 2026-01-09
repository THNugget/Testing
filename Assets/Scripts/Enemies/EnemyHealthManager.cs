using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public float heatlh = 3f;

    // Update is called once per frame
    void Update()
    {
        if (heatlh <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            heatlh -= 1;
        }
    }

}
