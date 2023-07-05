using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    [SerializeField] private GameObject playerTwoBoard;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerTwoBoard.transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        if (Input.GetKey(KeyCode.S))
        {
            playerTwoBoard.transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
