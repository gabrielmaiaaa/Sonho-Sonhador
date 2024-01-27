using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela_Inicial : MonoBehaviour
{
    [SerializeField] private string Jogo;
    [SerializeField] private GameObject Credito;
    [SerializeField] private GameObject Configuracao;
    [SerializeField] private GameObject Lore;

    public void Jogar()
    {
        SceneManager.LoadScene(Jogo);
    }

    public void AbrirConfiguracao()
    {
        Configuracao.SetActive(true);
    }

    public void AbrirCreditos()
    {
        Credito.SetActive(true);
    }

    public void FecharCreditos()
    {
        Credito.SetActive(false);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    public void historia()
    {
        Lore.SetActive(true);
    }
}
