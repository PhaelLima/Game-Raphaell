using UnityEngine;

public class KillerZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Health health))
            Debug.Log("OSTACOLO TOCCATO DA: " + other.name);

        {
            health.TakeDamage();
            health.TakeDamage();
            health.TakeDamage();
            health.TakeDamage();

        }
    }
}
