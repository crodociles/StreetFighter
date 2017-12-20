using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour {

    public float speed;
    public bool facingRight = true;
    public bool movingRight;

	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
            movingRight = false;
            flip();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
            movingRight = true;
            flip();
        }
    }

    public void flip()
    {
        if(facingRight && !movingRight)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            facingRight = false;
        }
        if(!facingRight && movingRight)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            facingRight = true;
        }
    }
}
