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



    private void Awake()
    {

    }

    private void OnEnable()
    {

    }
    private void OnDisable()
    {
        
    }
}
