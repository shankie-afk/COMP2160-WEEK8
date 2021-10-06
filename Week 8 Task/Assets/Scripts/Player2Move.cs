using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float speed = 2f;
    public const string Horizontal2 = "Horizontal2";
    public const string Vertical2 = "Vertical2";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float fy = Input.GetAxis(InputAxes.Vertical2) * speed;
        float fx = Input.GetAxis(InputAxes.Horizontal2) * speed;

        transform.Translate(fy * Vector3.forward * Time.deltaTime);
        transform.Translate(fx * Vector3.right * Time.deltaTime);

    }

}




