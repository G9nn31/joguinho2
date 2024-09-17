using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NewBehaviourScript : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audioSource;
    private String mensagemOriginal;
    public bool imprimindo;
    public float tempoEntreLetras = 0.08f;



    private void Awake()
    {
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audioSource);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";
    }

    private void OnEnable()
    {
        ImprimirMensagem(mensagemOriginal);
    }
    private void OnDisable()
    {
        componenteTexto.text = mensagemOriginal;
        stopAllCoroutines();
    }
    public  void ImprimirMensagem(string mensagem)
    {
        if(gameObject.activeInHierarchy)
        {
            if(imprimindo) return;
            imprimindo = true;
            StarCoroutine(mensagem);
        }
    }
    IEnumerator LetraPorLetra( String mensagem)
    {
        string msg = "";
        foreach(var letra in mensagem)
        {
            msg += letra;
            componenteTexto.text = msg;
            _audioSource.Play();
            yield return new WaitForSeconds(tempoEntreLetras );
        }
        imprimindo = false;
        stopAllCoroutines();
    }
}
