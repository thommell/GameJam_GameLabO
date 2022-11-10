using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private float vertical;
    private float speed = 8f;
    private bool isLadder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D _rb;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // Parses information (from player input) into vertical
        vertical = Input.GetAxis("Vertical");

        // Check if player is on the ladder and player is moving
        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }
    private void FixedUpdate()
    {
        // Player on the ladder
        if (isClimbing)
        {
            _rb.gravityScale = 0f;
            _rb.velocity = new Vector2(_rb.velocity.x, vertical * speed);
        }
        else
        // Player not on ladder
        {
            _rb.gravityScale = 4f;
        }
    }
    // Player enters ontrigger ladder
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }
    // Player exits ontrigger ladder
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
