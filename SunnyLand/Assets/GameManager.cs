using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    int points = 0;
    int vida = 5;
    public TMP_Text texto_pontuação;
    public TMP_Text texto_vida;
    public Image coracao;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void adicionarPontos(int valor) {
        points += valor;
        texto_pontuação.text = "pontos: " + points.ToString();
    }
    public void adicionarVida(int valorV) {
        if (vida >= 5)
        {
            return;
        }
        vida += valorV;
        texto_vida.text = "pontos: " + vida.ToString();


    }
    public void retirarVida(int valorV)
    {
        if (vida <= 1) { 
            texto_vida.text = "game over";
            return;        
        }
        vida -= valorV;
        texto_vida.text = "pontos: " + vida.ToString();
        print(valorV);


    }

   

}
