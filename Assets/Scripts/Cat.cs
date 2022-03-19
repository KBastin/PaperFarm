using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    [SerializeField]
    private float xRange = 3;
    private bool isHeadingRight = true;


    protected override void Move()
    {
        CheckDirection();
        if(isHeadingRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime, Space.World);
        } else
        {
            transform.Translate(Vector3.left * Time.deltaTime, Space.World); 
        }
    }

    private void CheckDirection()
    {
        if (gameObject.transform.position.x < -xRange)
        {
            gameObject.transform.Rotate(new Vector3(0, 180));
            isHeadingRight = true;
        }
        if(gameObject.transform.position.x > xRange)
        {
            gameObject.transform.Rotate(new Vector3(0, 180));
            isHeadingRight = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
