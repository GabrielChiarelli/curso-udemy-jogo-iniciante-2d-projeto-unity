using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorAleatorio : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosDeSpawn;

    public float tempoEntreOsSpawns;
    public float tempoAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtual -= Time.deltaTime;

        if(tempoAtual <= 0)
        {
            int objetoAleatorio = Random.Range(0, objetosParaSpawnar.Length);
            int pontoAleatorio = Random.Range(0, pontosDeSpawn.Length);

            Instantiate(objetosParaSpawnar[objetoAleatorio], pontosDeSpawn[pontoAleatorio].position, pontosDeSpawn[pontoAleatorio].rotation);
            tempoAtual = tempoEntreOsSpawns;
        }
    }
}
