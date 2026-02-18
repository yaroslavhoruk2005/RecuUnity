using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    [Header("---MOVIMIENTO---")]
    public float velocidad = 5f;
    private float movimientox;
    private Rigidbody2D rb2d;

    [Header("---SALTO---")]
    public float fuerzasalto = 5f;
    private bool ensuelo = false;

    [Header("---COMPRUEBASUELO---")]
    public Transform Compruebasuelo;
    public float radiosuelo = 0.1f;
    public LayerMask capasuelo;

    [Header("---VIDA---")]
    public TMP_Text valorvida;
    private int vida;

    [Header("---AUDIO---")]
    public AudioSource audioSource;
    public AudioClip musicamario;
    public AudioClip SonidoMoneda;
    

    private Vector3 posicionInicial;
    void Start()
    {
        vida = 2;
        valorvida.text = "2";

        rb2d = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicamario;
        audioSource.loop = true;
        audioSource.volume = 0.5f;  
        audioSource.Play();

    }
}