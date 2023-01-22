using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterRUSMAN_Movement : MonoBehaviour
{

    #region
    [SerializeField]
    [Range(1,5)]
    float speed;
    Rigidbody2D rb;
    PolygonCollider2D coll;
    float movex;
    float movey;
    Vector2 move;
    bool facingLeft;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>(); 
    }


    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        move = new Vector2(movex * speed, movey * speed);
        rb.AddForce(move);
        if (movex > 0 && facingLeft)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingLeft = false;
        }
        if (movex < 0 && !facingLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
