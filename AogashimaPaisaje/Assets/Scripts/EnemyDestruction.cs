using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(gameObject);
            GameObject explosionTemporal = Instantiate(explosivePrefab, inicioExplosive.transform.position, inicioExplosive.transform.rotation) as GameObject;
        }
    }
}
