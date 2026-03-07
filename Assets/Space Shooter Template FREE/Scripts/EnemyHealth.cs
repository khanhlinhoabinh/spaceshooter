using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;

    private void Awake()
    {
        LivingEnemyCount++;
        Debug.Log("Enemy spawned: " + LivingEnemyCount);
    }

    protected override void Die()
    {
        LivingEnemyCount--;
        Debug.Log("Enemy died. Remaining: " + LivingEnemyCount);
        base.Die();
    }
}