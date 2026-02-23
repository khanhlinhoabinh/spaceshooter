using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        GameOverUI ui = FindObjectOfType<GameOverUI>();

        if (ui != null)
            ui.ShowGameOver();

        base.Die();
    }


}
