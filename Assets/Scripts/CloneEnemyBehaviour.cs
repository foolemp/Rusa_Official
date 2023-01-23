using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloneEnemyBehaviour : MonoBehaviour
{
    private Animator m_animator;
    Rigidbody2D rb;
    [SerializeField]
    private float distanceToChase;
    [SerializeField]
    Transform target;
    [SerializeField]
    [Range(0, 10)]
    float moveSpeed = 0.5f;
    bool facingLeft;
    private bool chase = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(chase == false){
            if (Vector3.Distance(transform.position, target.position) < distanceToChase){
            chase = true;
            }
        }
        if (chase == true){
            Chase();
        }
    }

    void Chase()
    {
        float distance = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.position - transform.position;

        //m_animator.SetInteger("AnimState", 2);
        transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        
    }


    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2);
            //GameManager.ChangeScene(GameManager.GameOverScene);
            
        }

    }

}
