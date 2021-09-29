using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public const string Horizontal = "Horizontal";
    public const string Vertical = "Vertical";

    // Start is called before the first frame update
    void Start()
    {
    //  curSpeed = speed;   
    }

    // Update is called once per frame
    void Update()
    {
    // Up and Down for Foward and Back
    float dy = Input.GetAxis(InputAxes.Vertical) * speed ;
    transform.Translate(0,0,dy * Time.deltaTime );

    // Left and Right for Rotate 
    float dx = Input.GetAxis(InputAxes.Horizontal) * speed ;
    transform.Translate(0, dx , 0 * Time.deltaTime );
    }
}


   
    



