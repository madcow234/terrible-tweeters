using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // Takes the bird out of physics control
        // This is so we can aim it and it does not automatically fall to the ground
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}