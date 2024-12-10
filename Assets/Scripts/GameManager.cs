using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
    }
    public void Perder()
    {

    }

    public void ReiniciarJuego()
    {

    }


    public void ActualizarPuntuacion()
    {

    }
}
