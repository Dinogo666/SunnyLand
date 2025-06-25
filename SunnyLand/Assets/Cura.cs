using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cura : MonoBehaviour {
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
            gameManager.adicionarVida(1);
            Instantiate(efeito, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

}
