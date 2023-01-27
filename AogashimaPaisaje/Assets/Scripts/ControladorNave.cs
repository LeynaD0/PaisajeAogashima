using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNave : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float speedRotationVertical = 10;
    [SerializeField]
    float speedRotationHorizontal = 10;
    [SerializeField]
    float speedEstabilitation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical") * speedRotationVertical * Time.deltaTime;

        float rotationZ = Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;

        transform.Rotate(-rotationX, 0f, -rotationZ, Space.Self);

        //transform.Rotate(0f, rotationY, 0f, Space.Self);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed += Time.deltaTime * 4;
            if(speed >= 10)
            {
                speed = 10;
            }
        }
        else
        {
            speed -= Time.deltaTime * 2;
            if(speed <= 5)
            {
                speed = 5;
            }
        }

        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
