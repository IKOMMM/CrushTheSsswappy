using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] GameObject explosionAnimation;
    [SerializeField] GameObject enemySprite;
    [SerializeField] GameObject enemyObject;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TowerElement")
        {
            enemySprite.SetActive(false);
            explosionAnimation.SetActive(true);
            Invoke(nameof(DestroyEnemy), 0.5f);
        }
    }

    void DestroyEnemy()
    {
        Destroy(enemyObject);
    }

}
