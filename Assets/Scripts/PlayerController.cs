using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject playerOneBoard;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            playerOneBoard.transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerOneBoard.transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
