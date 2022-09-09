using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCreate : MonoBehaviour
{
    public GameObject ground;
    private float increment = 0.1f;
    private bool Grounded;
    // Start is called before the first frame update
    //void Start()
    //{


    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            InvokeRepeating("Ground", 0,0);
        }
        //Selse Grounded = false;

    }

    // Update is called once per frame
    void Ground()
    {
        float Spawn = transform.position.x + increment;
        Instantiate(ground, transform.position = new Vector3(Spawn, -2.66f, -8.057973f), Quaternion.identity);
        Debug.Log(Spawn);
    }
}
