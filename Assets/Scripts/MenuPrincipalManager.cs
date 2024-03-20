using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDaCenaJogo;
    
    public void Jogar(){
        SceneManager.LoadScene(nomeDaCenaJogo);
    }

    public void Sair(){
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
