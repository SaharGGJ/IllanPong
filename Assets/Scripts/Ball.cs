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
}
