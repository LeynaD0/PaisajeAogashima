using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    bool powerUpActivated;
    [SerializeField]
    float timePowerUp = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(powerUpActivated == true)
        {
            timePowerUp -= Time.deltaTime;

            if(timePowerUp <= 0)
            {
                powerUpActivated = false;
                timePowerUp = 20f;
                DisparoNave.instance.cooldown = 0.75f;
                DisparoNave.instance.cooldown = 0.75f;

            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            Debug.Log("Toco");
            if(powerUpActivated == false)
            {
                Destroy(collision.gameObject);
                powerUpActivated = true;
                DisparoNave.instance.timeShoot /= 2;
                DisparoNave.instance.cooldown /= 2;
            }
        }
    }
}
