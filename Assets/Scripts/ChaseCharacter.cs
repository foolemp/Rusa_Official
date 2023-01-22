using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCharacter : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterPosition = player.position;
        transform.position = characterPosition - new Vector3(0.5f, -1, 0);

    }

}



