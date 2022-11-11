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

    void Start()
    {

        player = GameObject.Find("Player");
    }

    void DragObject(Collision col)
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Clicked");
            if (col.onRightDrag)
                transform.position = (Vector2)player.transform.position + offset;
            if (col.onLeftDrag)
                transform.position = (Vector2)player.transform.position - offset;
        }
    }

    void Update()
    {
        //DragObject(col);
        if (Input.GetKeyDown(KeyCode.L))
        {
            isHolding = true;
        }
        
        if (Input.GetKeyDown(KeyCode.L)) transform.position = (Vector2)player.transform.position + offset;
        if (Input.GetKeyUp(KeyCode.L)) transform.position = player.transform.position;

    }
}
