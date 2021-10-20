using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public const string Horizontal = "Horizontal";
    public const string Vertical = "Vertical";

    void Update()
    {
        float dy = Input.GetAxis(InputAxes.Vertical) * speed;
        float dx = Input.GetAxis(InputAxes.Horizontal) * speed;

        transform.Translate(dy * Vector3.forward * Time.deltaTime);
        transform.Translate(dx * Vector3.right * Time.deltaTime);
    }

}




