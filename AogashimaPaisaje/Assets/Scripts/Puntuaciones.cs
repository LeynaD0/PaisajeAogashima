using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuaciones : MonoBehaviour
{
    int naves = 0;
    public static Puntuaciones instance;
    [SerializeField]
    TextMeshProUGUI contadorText;
    private void Awake()
    {
        if(Puntuaciones.instance != null && Puntuaciones.instance != this)
        {
            Destroy(this);
        }
        else
        {
            Puntuaciones.instance = this;
        }
    }

    public void NaveDestruida()
    {
        naves++;
        contadorText.text = "Destroy: " + naves;
    }
    
}
