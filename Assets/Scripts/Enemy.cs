using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float RotaionSpeed;
    public GameObject DustEffect;
    // Start is called before the first frame update
   
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotaionSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.reference.GameOver(); 
        }
        else if (collision.gameObject.tag == "Floor")
        {
            GameManager.reference.ScoreIncrease();
            GameObject DestroyEffect=Instantiate(DustEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(DestroyEffect, 1);
        } 
    }
}
