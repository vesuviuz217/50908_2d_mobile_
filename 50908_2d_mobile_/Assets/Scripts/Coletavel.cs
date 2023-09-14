using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    
    void FixedUpdate()
    {
        rig.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
    }
}
