using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuntosControl : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] TMP_Text puntuacionActual,puntuacionMaxima,tiempo;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int minutos = (int)gameManager.tiempo / 60;
        int segundos = (int)gameManager.tiempo % 60;
        Debug.Log($"{minutos:D2} : {segundos:D2}");
        tiempo.text = ($"{minutos:D2} : {segundos:D2}");

        puntuacionActual.text = gameManager.puntuacionActual.ToString();
        puntuacionMaxima.text = gameManager.puntuacionMaxima.ToString();
    }
}
