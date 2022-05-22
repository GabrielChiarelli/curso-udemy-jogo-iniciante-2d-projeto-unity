using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        FindObjectOfType<Musicas>().TocarMusicaDeFundo();
    }

    public void IniciarJogo()
    {
        Time.timeScale = 1f;
        this.gameObject.SetActive(false);
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
