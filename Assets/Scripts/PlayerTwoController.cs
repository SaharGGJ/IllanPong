using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    [SerializeField] private GameObject playerTwoBoard;
    [SerializeField] private AudioSource playerTwoAudioSource;
    public float speedMod = 1;
    private bool touchingTop = false;
    private bool touchingBottom = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !touchingTop)
        {
            playerTwoBoard.transform.Translate(Vector3.up * Time.deltaTime * speedMod);
        }
        else
        if (Input.GetKey(KeyCode.S) && !touchingBottom)
        {
            playerTwoBoard.transform.Translate(Vector3.down * Time.deltaTime * speedMod);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Top Border"))
        {
            touchingTop = true;
            Debug.Log("Hitting top!");
        }
        if (collision.gameObject.tag.Equals("Bottom Border"))
        {
            touchingBottom = true;
            Debug.Log("Hitting Bottom!");
        }
        if (collision.gameObject.tag.Equals("Ball"))
        {
            playerTwoAudioSource.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingBottom = false;
        touchingTop = false;
    }
}
