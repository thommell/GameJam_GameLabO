using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour{

    private float length, startPos;
    public GameObject cam;
    public float parallexEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallexEffect);

        transform.position = new Vector3(cam.transform.position.x + dist, transform.position.y, transform.position.z);
        
    }
}