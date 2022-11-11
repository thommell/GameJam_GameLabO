using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragableObject : MonoBehaviour
{
    private GameObject player;

    public Vector2 offset;

    public Collision col;

    private bool isHolding;
    private bool isPressed;

    void Start()
    {

        player = GameObject.Find("Player");
    }

   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) isPressed = !isPressed;

        if (isPressed)
        {
            if (player.transform.position.x < transform.position.x)
            {
                transform.position = (Vector2)player.transform.position + offset;
            }
            else
            {
                transform.position = (Vector2)player.transform.position - offset;
            }

        }
        
    }
}
