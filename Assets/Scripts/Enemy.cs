using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    //public static event Action<Enemy> OnEnemyKilled;
    [SerializeField]
    float health, maxHealth = 2f;
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
            //Destroy(enemy);
            //Instantiate(enemy, enemy.transform.position + new Vector3(0f, 1f, 0f), transform.rotation());
            //Instantiate(enemy, enemy.transform.position + new Vector3(0f, -1f, 0f), tranform.rotation());
            
            Vector3 enemyPosition = gameObject.transform.position;
            Vector3 newEnemyPosition1 = enemyPosition + new Vector3(-1f, 0.5f, 0f);
            Vector3 newEnemyPosition2 = enemyPosition + new Vector3(-2f, 0.5f, 0f);
            Instantiate(enemy, newEnemyPosition1, Quaternion.identity);
            Instantiate(enemy, newEnemyPosition2, Quaternion.identity);
            Destroy(gameObject);
            //Instantiate(gameObject, GameObject.FindGameObjectWithTag("Enemy").transform.position + new Vector3(0f, 1f, 0f));
            //Instantiate(gameObject, GameObject.FindGameObjectWithTag("Enemy").transform.position + new Vector3(0f, -1f, 0f));
            //OnEnemyKilled?.Invoke(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameObject.FindGameObjectWithTag("Enemy").transform.position);
        Vector3 enemyPosition = GameObject.FindGameObjectWithTag("Enemy").transform.position;
        Vector3 enemyPosition2 = enemyPosition + new Vector3(1f, 1f, 1f);
        //Debug.Log(enemy.transform.position);
    }
}
