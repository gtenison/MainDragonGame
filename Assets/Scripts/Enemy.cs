using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData data;
    private int currentHealth;
    private void Start()
    {
        currentHealth = data.maxHealth;

        // SpriteRenderer sr = GetComponent<SpriteRenderer>();
        // if (sr != null && data.enemySprite != null)
        // {
        //     sr.sprite = data.enemySprite;
        // }
    }

    private void OnMouseDown()
    {
        TakeDamage(1);
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log(data.enemyName + " took damage. HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        ResourceManager.instance.AddResources("Gold", data.goldReward);
        Debug.Log(data.enemyName + " defeated! +" + data.goldReward + " Gold");

        Destroy(gameObject);
    }
}
