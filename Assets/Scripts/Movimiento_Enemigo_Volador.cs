using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento_Enemigo_Volador : MonoBehaviour
{
    [SerializeField] float velocidadHorizontal, velocidadVertical, velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        velocidadHorizontal = 3;
        velocidadVertical = Random.Range(-.25f, .25f);
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidadHorizontal * Time.deltaTime);
        transform.Translate(Vector2.down * velocidadVertical * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            StartCoroutine(ReiniciarRecorrido());
        }
    }
    public IEnumerator ReiniciarRecorrido()
    {
        yield return new WaitForSeconds(Random.Range(0f, 2f));
        transform.position = posicionInicial;
        velocidadHorizontal += (Time.time / 50);
        velocidad += (Time.time / 50);
        if (velocidadHorizontal > 15)
        {
            velocidadHorizontal = 15;
        }
        if (velocidad > 10)
        {
            velocidad = 10;
        }
    }

    public void ReiniciarNivel()
    {
        velocidadHorizontal = 3;
        velocidad = 3;
        velocidadVertical = Random.Range(-.5f, .5f);
        transform.position = posicionInicial;
    }
}