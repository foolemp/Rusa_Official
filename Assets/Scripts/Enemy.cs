using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] float health, maxHealth = 2f;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        Debug.Log($"Damage Amount: {damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0)
        {
            Destroy(gameObject);
            //OnEnemyKilled?.Invoke(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
