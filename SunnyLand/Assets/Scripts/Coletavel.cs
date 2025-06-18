using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int pontos = 10;
    public GameManager gameManager;
    public ParticleSystem coletavelParticle;

    private bool hasBeenCollected = false; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pontos:" + pontos);
    }

    

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (hasBeenCollected) return;
        
        if (outroObjeto.CompareTag("Player"))
        {
            hasBeenCollected = true;
            gameManager.AdicionarPontos(pontos); // Chama o método do GameManager para adicionar pontos

            outroObjeto.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f); // Aumenta o tamanho do jogador ao coletar o item
            Instantiate(coletavelParticle, transform.position, Quaternion.identity); // Instancia a partícula de coleta
            // Aqui você pode adicionar lógica para aumentar a pontuação do jogador
            Destroy(gameObject); // Destroi o coletável após ser coletado
        }
        
    }
}
