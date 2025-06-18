using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public ParticleSystem efeito;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("jogo começou uhuu");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("yes");
            other.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            gameManager.adicionarPontos(1);
            Destroy(gameObject);
        }
    }

}