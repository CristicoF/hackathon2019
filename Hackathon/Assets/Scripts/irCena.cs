using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class irCena : MonoBehaviour
{
    public int scene;
    //Aqui é só pra ir passando as cenas de acordo com os botões
    //public string Evidencias; //Chitaozinho e Xororo pq sim
    //Martini me deu essa ideia no metrô pra no final gerar um documento de texto pra auxiliar a pessoa a chegar no lugar certo
    //public Text arqText;
    
    //private CompiladorEvidencias compiladorEvidencias;
    
    public void LoadIndex(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    //public void Armazem()
    //{
        //Evidencias = arqText.text ;
        //compiladorEvidencias = GetComponent<CompiladorEvidencias>();
        //compiladorEvidencias.lista = arqText.text;
    //   ç}

}
