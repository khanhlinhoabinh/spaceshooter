using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra có phải Bullet không
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            // HỦY VIÊN ĐẠN
            Destroy(collision.gameObject);

            // CHẾT ENEMY
            Die();
        }
    }

    private void Die()
    {
        if (explosionPrefab != null)
        {
            Instantiate(
                explosionPrefab,
                transform.position,
                Quaternion.identity
            );
        }

        Destroy(gameObject);
    }
}
