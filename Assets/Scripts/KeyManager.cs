using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyManager : MonoBehaviour
{
    
    [SerializeField] private string nomeDaCenaMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            ReturnMenu();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

     


    public void ReturnMenu(){
        SceneManager.LoadScene(nomeDaCenaMenu);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
