using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2;
    [SerializeField] Animator animator;
    [SerializeField] GameObject personaje;
    [SerializeField] float altura;
    [SerializeField] GameManager gameManager;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Parametro1",true);
            rigidbody2.velocity = Vector2.zero;
            rigidbody2.AddForce(Vector2.up * altura);

        }
       
      




    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Parametro1", false);


        if (collision.transform.tag == "Enemigo")
        {
            gameManager.Perder();
        }


     }

}
