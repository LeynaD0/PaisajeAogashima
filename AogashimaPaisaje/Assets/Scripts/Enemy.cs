using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    Vector3 siguientePunto;
    [SerializeField]
    float speed = 2f;
    [SerializeField]
    float distanciaCambio = 0.5f;
    int numeroSiguientePosicíon = 0;
    // Start is called before the first frame update
    void Start()
    {
        siguientePunto = waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, siguientePunto, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, siguientePunto) < distanciaCambio)
        {
            numeroSiguientePosicíon++;
            if(numeroSiguientePosicíon >= waypoints.Length)
            {
                numeroSiguientePosicíon = 0;
                siguientePunto = waypoints[numeroSiguientePosicíon].position;
            }
        }
    }
}
