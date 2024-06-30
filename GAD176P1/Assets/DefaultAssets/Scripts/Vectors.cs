using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Transform point;
    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddVectors();
            SubtractVectors();
            Angle();
            Rotate();
        }
       

    }


    void AddVectors()
    {
        transform.position += new Vector3(0, 1, 0);

    }

    void SubtractVectors()
    {
        Vector3 direction = (point.transform.position - transform.position);
        Debug.Log("Magnitude is " + direction.magnitude);
        direction = direction.normalized;
        Debug.Log("Normalised " + direction.magnitude);


    }

    void Angle()
    {
        Vector3 direction = point.position - transform.position;
        float angle = Vector3.Angle(transform.forward, direction);
        Debug.Log("The angle is " + angle);
    }

    void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, -60);
    }
}
