using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BrocoliRun()
    {
        SceneManager.LoadScene("Brocoli run");
    }
    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Cerrando");
    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void RetrocederJuego()
    {
        SceneManager.LoadScene("Menu Principal");
    }
    public void DosPlayer()
    {
        SceneManager.LoadScene("DosPlayer");
    }
    public void EscogerModo()
    {
        SceneManager.LoadScene("escoger modo");
    }

}
