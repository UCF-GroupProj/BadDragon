using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // Change position one to the left
        transform.position = transform.position + new Vector3((float)-0.09, 0, 0);
        if (transform.position.x < -12) Destroy(this.gameObject);
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision Detected!");
            Destroy(this.gameObject);
        }

    }
}
