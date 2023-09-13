using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-90, 90)));
    }

    // Update is called once per frame
    void Update()
    {
        rig.MovePosition(transform.position + Vector3.right * speed);
    }
}
