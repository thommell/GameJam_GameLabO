using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [Header("Layers")]
    public LayerMask groundLayer;
    public LayerMask player;

    [Space]
    // 
    public bool onGround;
    public bool onWall;
    public bool onRightWall;
    public bool onLeftWall;
    public bool onRightDrag;
    public bool onLeftDrag;
    /*public bool topRightWall;
    public bool topLeftWall;*/

    //
    public int wallSide;


    

    [Space]

    [Header("Collision")]

    public float collisionRadius = 0.25f;
    public float smallCollisionRadius = 0.1f;

    public Vector2 bottomOffset, rightOffset, leftOffset, topRightOffset, topLeftOffset;
    private Color debugCollisionColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        onGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, groundLayer);
        onWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, groundLayer) 
            || Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, groundLayer);

        onRightWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, groundLayer);
        onLeftWall = Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, groundLayer);

        onRightDrag = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, player);
        onLeftDrag = Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, player);

        /*topLeftWall = Physics2D.OverlapCircle((Vector2)transform.position + topLeftOffset, smallCollisionRadius, groundLayer);
        topRightWall = Physics2D.OverlapCircle((Vector2)transform.position + topRightOffset, smallCollisionRadius, groundLayer);*/

        wallSide = onRightWall ? -1 : 1;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        var positions = new Vector2[] { bottomOffset, rightOffset, leftOffset };

        Gizmos.DrawWireSphere((Vector2)transform.position  + bottomOffset, collisionRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, collisionRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, collisionRadius);
        /*Gizmos.DrawWireSphere((Vector2)transform.position + topRightOffset, smallCollisionRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + topLeftOffset, smallCollisionRadius);*/
    }
}
