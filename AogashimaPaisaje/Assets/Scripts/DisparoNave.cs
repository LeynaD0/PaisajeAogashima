using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    [SerializeField]
    GameObject balaInicio;
    [SerializeField]
    GameObject balaPrefab;
    [SerializeField]
    float velocidadBala;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject balaTemporal = Instantiate(balaPrefab, balaInicio.transform.position, balaInicio.transform.rotation) as GameObject;

            Rigidbody rigidbody = balaTemporal.GetComponent<Rigidbody>();

            rigidbody.AddForce(transform.forward * velocidadBala);

            Destroy(balaTemporal, 3);
        }
    }
}
