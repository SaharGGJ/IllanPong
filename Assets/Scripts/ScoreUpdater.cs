using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public scoreManagement scorer;
    public Transform rightBallSpawnPoint;
    public Transform leftBallSpawnPoint;
    public GameObject theBall;
    public bool isLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RespawnBall(bool diraction)
    {
        if (diraction)
        {
            theBall.transform.position = leftBallSpawnPoint.position;
        }
        else
        {
           theBall.transform.position = rightBallSpawnPoint.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {

            if (transform.position.x >= -1)
            {
                scorer.AddScoreToLeft();
                isLeft = false;
                RespawnBall(isLeft);
            }


            if (transform.position.x <= -10)
            {
                scorer.AddScoreToRight();
                isLeft = true;
                RespawnBall(isLeft);
            }



        }
    }
}
