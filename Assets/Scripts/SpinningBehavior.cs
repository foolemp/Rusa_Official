using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBehavior : MonoBehaviour
{

    public float spinSpeed = 50f; // The speed at which the object will spin

     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // Kill the player when the object touches it
            // you can use a function in your player script to handle this
            //collision.gameObject.GetComponent<Player>().Die();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local y-axis
        transform.Rotate(new Vector3(0f, spinSpeed * Time.deltaTime, 0f));
    }


}
