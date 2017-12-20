using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float playerSpeed;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;
    public bool isGrounded;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run
        if (!isGrounded && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            isGrounded = true;
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) && isGrounded)  //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}