using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyBehavior : MonoBehaviour
{
    
    Rigidbody2D rb;
    [SerializeField]
    Transform target;
    [SerializeField]
    [Range(0, 5)]
    float moveSpeed = 0.5f;
    bool facingLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
    }


    void Chase()
    {
        Vector3 direction = target.position - transform.position;
        rb.AddForce((direction).normalized * moveSpeed * 0.5f);
        if (direction.x > 0 && facingLeft)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingLeft = false;
        }
        if (direction.x < 0 && !facingLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingLeft = true;
        }

    }


    void Chase2()
    {
        float distance = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            GameManager.ChangeScene(GameManager.GameOverScene);
        }

    }

}
