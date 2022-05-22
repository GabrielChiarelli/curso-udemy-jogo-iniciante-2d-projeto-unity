using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public AudioSource somDaMoeda;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            other.GetComponent<Jogador>().AumentarQuantidadeDeMoedas();
            somDaMoeda.Play();
            Debug.Log("Moeda colidiu com o Jogador");
            Destroy(this.gameObject, 0.6f);
        }
    }
}
