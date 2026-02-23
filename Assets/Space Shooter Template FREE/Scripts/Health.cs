using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    int healthPoint;
    bool isDead = false;

    void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        healthPoint -= damage;

        if (healthPoint <= 0)
        {
            isDead = true;
            Die();
        }
    }

    protected virtual void Die()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
