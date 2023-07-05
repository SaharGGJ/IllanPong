using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject playerOneBoard;
    [SerializeField] private AudioSource playerOneAudioSource;
    public float speedMod = 1;
    private bool touchingTop = false;
    private bool touchingBottom = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)&&!touchingTop)
        {
            playerOneBoard.transform.Translate(Vector3.up * Time.deltaTime*speedMod);
        }
        else
        if (Input.GetKey(KeyCode.DownArrow)&&!touchingBottom)
        {
            playerOneBoard.transform.Translate(Vector3.down * Time.deltaTime * speedMod);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Top Border"))
            touchingTop= true;
        if (collision.gameObject.tag.Equals("Bottom Border"))
            touchingBottom= true;
        if (collision.gameObject.tag.Equals("Ball"))
            playerOneAudioSource.Play();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingBottom= false;
        touchingTop= false;
    }
}
