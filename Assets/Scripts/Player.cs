using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput;
    public float movementSpeed;
    Vector2 newPostion;
    public float positionLimit;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
           
    }

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        xInput = Input.GetAxis("Horizontal");
        newPostion = transform.position;
        newPostion.x = newPostion.x + xInput*movementSpeed;
        
        newPostion.x=Mathf.Clamp(newPostion.x, -positionLimit, positionLimit);
        rb.MovePosition(newPostion);
    }

}
