using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rigidbody2D;

    int x;
    float y;
    private Vector3 vector;

    void Start()
    {
        x = 2;
        y = 0.4f;
        vector= new Vector3(x,y,0);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = vector;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Top Border")|| collision.gameObject.tag.Equals("Bottom Border"))
        {
            vector.y*=-5;
        }
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Hit player");
            if(gameObject.transform.position.x>Screen.width/2)
            {
                //Rigidbody2D.velocity = new Vector3(-1,y,0);
                vector.x = -1;
            }
            //else
            //    Rigidbody2D.velocity = new Vector3(1, y, 0);
            vector.x *= -1;
        }
    }
}
