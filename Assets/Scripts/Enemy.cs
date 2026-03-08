using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Enemy : MonoBehaviour
{
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            HandlePlayerCollision(player, collision);
        }
    }

    protected virtual void HandlePlayerCollision(Player player, Collision2D collision)
    {
        // If player lands on enemy head
        if (player.transform.DotTest(transform, Vector2.down))
        {
            Stomped(player);
        }
        else
        {
            PlayerHit(player);
        }
    }

    protected virtual void Stomped(Player player)
    {
        Destroy(gameObject);
    }

    protected virtual void PlayerHit(Player player)
    {
        player.Hit();
    }
}
