using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public bool isRigth;
    public float speed;
    void Start()
    {
        
    }

   
    void Update()
    {
        // se verdadeiro vai para a direita
        if (isRigth)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else // se falso vai para a esqueda
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if(Input.GetMouseButtonDown(0))
        {
            isRigth = !isRigth;
        }
    }
}
