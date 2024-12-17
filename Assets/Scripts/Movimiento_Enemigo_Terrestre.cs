using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento_Enemigo_Terrestre : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 3;
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            StartCoroutine(ReiniciarRecorrido());
        }
    }

    public IEnumerator ReiniciarRecorrido()
    {
        yield return new WaitForSeconds(Random.Range(5, 10));
        transform.position = posicionInicial;
        velocidad += (Time.time / 10);
        if (velocidad > 15)
        {
            velocidad = 15;
        }
    }

    public void ReiniciarNivel()
    {
        velocidad = 3;
        transform.position = posicionInicial;
    }
}