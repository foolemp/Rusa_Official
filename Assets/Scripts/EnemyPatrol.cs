using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour{
    Rigidbody2D rb;
    [SerializeField] float      speed = 4.0f;
    //[SerializeField] float    jumpForce = 7.5f;
    [SerializeField] Transform  pointA;
    [SerializeField] Transform  pointB;
    private Transform target;

    
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        var step =  speed * Time.deltaTime; // calculate distance to move
        target = pointA.transform;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    // Update is called once per frame
    void Update(){
        Auto_movement();
    }

        
    void Auto_movement(){
        if (Vector3.Distance(transform.position, pointA.position) < 0.001f){
            target = pointB;
        }else if(Vector3.Distance(transform.position, pointB.position) < 0.001f){
            target = pointA;
        //}else{
           //m_animator.SetInteger("AnimState", 1);
        }
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }


    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(3);
            //GameManager.ChangeScene(GameManager.GameOverScene);
        }

    }

}
