using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyDestruction : MonoBehaviour
{
    [SerializeField]
    GameObject inicioExplosive;
    [SerializeField]
    GameObject explosivePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            Debug.Log("Le dio");
            Puntuaciones.instance.NaveDestruida();            
            GameObject explosionTemporal = Instantiate(explosivePrefab, inicioExplosive.transform.position, inicioExplosive.transform.rotation) as GameObject;

            Destroy(gameObject);
        }
    }
}
