using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;
    public bool isGrounded;

	// Use this for initialization
	void Start () {
        speed = 5f;
        isGrounded = true;
	}
	
	// Update is called once per frame
	void Update () {
        HandleInput();
	}

    void HandleInput()
    {
         #region Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2D.velocity = new Vector2(-speed, rigidbody2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (isGrounded)
            {
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 4);
            }
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        }
        #endregion
    }


    void Jump()
    {

    }
}
