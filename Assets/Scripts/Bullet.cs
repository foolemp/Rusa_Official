using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody2D rb; 

    void OnCollisionEnter2D(Collision2D other)
    {
        switch(other.gameObject.tag)
        {
            //case "Floor":
            //Instantiate(gameObject);
            //gameObject.Collision();
            //break;

            case "Enemy":
            Destroy(gameObject);
            other.gameObject.GetComponent<Enemy>().TakeDamage(1.0f);
            break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
