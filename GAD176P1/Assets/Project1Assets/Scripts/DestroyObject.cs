using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public float time;

    void Start()
    {
        Destroy(gameObject, time); //Destroys objects after a certain amount of time (edit in inspector)
    }

   

}
