using UnityEngine;

public class DragonFollower : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private float followSpeed = 3f;
    [SerializeField] private float distanceBehind = 1.5f;

    private Vector2 lastPlayerDirection = Vector2.left;

    void Update() {
        // Try to get player movement direction (using Rigidbody2D or custom logic)
        Vector2 direction = (player.position - transform.position).normalized;

        // Update only if player is moving
        if (direction.magnitude > 0.1f) {
            lastPlayerDirection = direction;
        }

        // Offset behind player direction
        Vector3 offset = -((Vector3)lastPlayerDirection * distanceBehind);
        Vector3 targetPos = player.position + offset;

        // Smooth follow
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
    }
}
