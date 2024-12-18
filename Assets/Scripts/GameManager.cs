using System.Collections;
using System.Collections.Generic;
using UnityEditor.Advertisements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] GameObject gameOver, buttom, jugador, enemigo1, enemigo2, enemigo3, enemigo4;
    [SerializeField] bool cronometro;
    [SerializeField] Movimiento_Enemigo_Terrestre reiniciarTerrestre1, reiniciarTerrestre2;
    [SerializeField] Movimiento_Enemigo_Volador reiniciarVolador1, reiniciarVolador2;
 
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
        gameOver.SetActive(false);
        buttom.SetActive(false);
        puntuacionActual = -1;
        cronometro = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometro == true)
        {
            tiempo += Time.deltaTime;
        }


        
    }
    public void Perder()
    {
        jugador.SetActive(false);
        enemigo1.SetActive(false);
        enemigo2.SetActive(false);
        enemigo3.SetActive(false);
        enemigo4.SetActive(false);
        gameOver.SetActive(true);
        buttom.SetActive(true);
        cronometro = false;
    }

    public void ReiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo1.SetActive(true);
        enemigo2.SetActive(true);
        enemigo3.SetActive(true);
        enemigo4.SetActive(true);
        gameOver.SetActive(false);
        buttom.SetActive(false);
        cronometro = true;
        tiempo = 0;
        reiniciarTerrestre1.ReiniciarNivel();
        reiniciarTerrestre2.ReiniciarNivel();
        reiniciarVolador1.ReiniciarNivel();
        reiniciarVolador2.ReiniciarNivel();

    }


    public void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
        }
    }
}
