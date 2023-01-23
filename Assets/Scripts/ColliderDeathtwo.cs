using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderDeathtwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(3);
        }
        if (other.gameObject.name == "skull-red")
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(2.0f);
        }
    }
}
