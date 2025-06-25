using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome = "Penis";
    public int vida = 0;
    public float velocidade = 5.3f;
    private bool vivo = true;
    private Rigidbody2D rb;
    public float novaGravidade = 0f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" Nome: " + nome + "\n Vida: " + vida + "\n Velocidade: " + velocidade + "\n Vivo: " + vivo+ ".");
    rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
