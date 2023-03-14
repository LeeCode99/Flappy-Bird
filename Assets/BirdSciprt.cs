using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSciprt : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource jumpSFX;
    public static bool counter = true;
    public static int start = 1;

    private void jumpBing()
    {
        jumpSFX.Play();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (start == 1)
        {
            logic.gameStart();
            counter = false;
            start++;
        }
        myRigidbody.velocity = Vector2.up * flapStrength;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            jumpBing();
        }
        else if (Input.GetMouseButtonDown(0) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            jumpBing();
        }
        if (transform.position.y >= 17 || transform.position.y <= -17 && birdIsAlive && start != 1)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
