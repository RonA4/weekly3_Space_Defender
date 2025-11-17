using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will take damage")]
    [SerializeField] string triggeringTag = "Player";

    [Tooltip("How much damage to deal on hit (1 = half haret)")]
    [SerializeField] int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enabled) return;

        if (other.CompareTag(triggeringTag))
        {
      
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

          
            Destroy(gameObject);
        }
    }

    private void Update()
    {
     
    }
}
