using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
            gameManager.ActualizarPuntuacion();
        
    }
}