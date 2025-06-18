using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int points = 0;
    public TMP_Text texto_pontuação;

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
}
