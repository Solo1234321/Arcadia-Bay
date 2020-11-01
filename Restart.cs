    qusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // A Unity não carrega Cenas por padrão esta linha serve para ela poder carregar as cenas


public class Restart : MonoBehaviour
{

    public string faseParaCarregar; // Criei uma variavel para a unity entender qual fase é para carregar.

    void Start()
    {
        
    }
  
    void Update() // Verifica algo a cada frame do jogo
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Verifica se o espaço esta apertado, se estiver, ira rodar o codigo.
        {
            SceneManager.LoadScene(faseParaCarregar); // Manda a unity carregar a var. faseParaCarregar q esta difinido no proprio layout da unity.
        }
    }
}
