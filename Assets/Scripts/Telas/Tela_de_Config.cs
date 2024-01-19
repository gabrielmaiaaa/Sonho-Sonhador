using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela_de_Config : MonoBehaviour
{
    [SerializeField] private GameObject configuracoes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            configuracoes.SetActive(false);
            Tela_de_Pause.Configuracao_Aberto = false;
        }
    }

    public void AtualizarSensibilidade(float value)
    {
        Movement.rotation = value;
    }

    public void SairConfiguracao()
    {
        configuracoes.SetActive(false);
        Tela_de_Pause.Configuracao_Aberto = false;
    }
}
