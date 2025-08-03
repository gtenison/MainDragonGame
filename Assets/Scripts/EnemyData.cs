using UnityEngine;

[CreateAssetMenu(menuName = "Game/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int maxHealth = 5;
    public int damage = 1;
    public int goldReward = 5;
    public Sprite enemySprite;
}
