using UnityEngine;

public class StunEnemy : Enemy
{
    public float stunDuration = 2.5f;

    protected override void PlayerHit(Player player)
    {
        PlayerMovement movement = player.GetComponent<PlayerMovement>();

        if (movement != null)
        {
            movement.Stun(stunDuration);
        }
    }

    protected override void Stomped(Player player)
    {
        Destroy(gameObject);
    }
}
