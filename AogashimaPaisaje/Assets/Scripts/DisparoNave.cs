using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    public static DisparoNave instance;
    [SerializeField]
    GameObject balaInicio;
    [SerializeField]
    GameObject balaPrefab;
    [SerializeField]
    float velocidadBala;
    
    public float timeShoot = 0.75f;
    
    public float cooldown = 0.75f;

    private void Start()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }

        else
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timeShoot -= Time.deltaTime;

            if(timeShoot <= 0)
            {
                GameObject balaTemporal = Instantiate(balaPrefab, balaInicio.transform.position, balaInicio.transform.rotation) as GameObject;

                Rigidbody rigidbody = balaTemporal.GetComponent<Rigidbody>();

                rigidbody.AddForce(transform.forward * velocidadBala);

                Destroy(balaTemporal, 3);

                if(timeShoot < 0)
                {
                    timeShoot = cooldown;
                }
            }
        }

        else
        {
            timeShoot = cooldown;
        }
    }
}
