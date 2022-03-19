using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Pig : Animal
{
    [SerializeField]
    private float zRange = 2;
    protected override void Move()
    {
        CheckDirection();
        transform.Translate(Vector3.right * Time.deltaTime);
    }

    private void CheckDirection()
    {
        if (gameObject.transform.position.z < -zRange)
        {
            gameObject.transform.Rotate(new Vector3(0, 180));
        }
        if (gameObject.transform.position.z > zRange)
        {
            gameObject.transform.Rotate(new Vector3(0, 180));
        }
    }
}
