using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : Animal
{
    [SerializeField]
    private float maxFlyHeight = 2;
    private bool isFlying = false;

    protected override void Move()
    {
        CheckIfFlying();
        if (isFlying)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }

    private void CheckIfFlying()
    {
        if (transform.position.y > maxFlyHeight)
        {
            isFlying = false;
        }

        if (transform.position.y < 0)
        {
            isFlying = true;
        }
    }
}
