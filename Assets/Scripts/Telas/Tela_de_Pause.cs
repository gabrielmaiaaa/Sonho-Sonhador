using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela_de_Pause : MonoBehaviour
{
    public GameObject Tela_Pausada;
    public static bool pause;

    [SerializeField] private string menu;
    [SerializeField] private GameObject configuracoes;
    public static bool Configuracao_Aberto;

    void Start()
    {
        Tela_Pausada.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!Configuracao_Aberto)
            {
                if (pause)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Tela_Pausada.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Tela_Pausada.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    public void Voltar()
    {
        ResumeGame();
    }

    public void Configuracao()
    {
        configuracoes.SetActive(true);
        Configuracao_Aberto = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene(menu);
        ResumeGame();
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
