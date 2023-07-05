using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rigidbody2D;

    int x;
    float y;

    void Start()
    {
        x = 2;

        y = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = new Vector3(x, y, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Top Border")|| collision.gameObject.tag.Equals("Bottom Border"))
        {
            Rigidbody2D.velocity = new Vector3(x,y*-5,0); 
        }
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Hit player");
            if(gameObject.transform.position.x>Screen.width/2)
            {
                Rigidbody2D.velocity = new Vector3(-1,y,0);
            }
            else
                Rigidbody2D.velocity = new Vector3(1, y, 0);
            Rigidbody2D.velocity = new Vector3(-1*x, y, 0);
        }
    }
}
