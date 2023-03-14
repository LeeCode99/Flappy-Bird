using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScripta : MonoBehaviour
{

    public float moveSpeed = 10;
    public float deadZone = -25;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        if(transform.position.x < deadZone){
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
        // Debug.Log(logic.scoreText.text);
        int a = int.Parse(logic.scoreText.text);
        if(a >= 10){
            // moveSpeed += 1;
        }
    }
}
