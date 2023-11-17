using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject home;
    public GameObject questao1;
    public GameObject acertou;
    public GameObject errou;

    // Start is called before the first frame update
    void Start()
    {
        home = GameObject.FindGameObjectWithTag("Home"); home.SetActive(true);
        questao1= GameObject.FindGameObjectWithTag("Questao1"); questao1.SetActive(false);
        acertou = GameObject.FindGameObjectWithTag("Acertou"); acertou.SetActive(false);
        errou = GameObject.FindGameObjectWithTag("Errou"); errou.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Iniciar()
    {
        home.SetActive(false);
        questao1.SetActive(true);
    }

   public void Acertou(){
        questao1.SetActive(false);
        acertou.SetActive(true);
    }

    public void Errou(){
        questao1.SetActive(false);
        acertou.SetActive(false);
        errou.SetActive(true);
    }

    public void Reiniciar(){
        questao1.SetActive(false);
        acertou.SetActive(false);
        errou.SetActive(false);

        home.SetActive(true);
    }
}
