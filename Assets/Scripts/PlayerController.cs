using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Creamos una instancia de nuestro InputPlayer
    private InputPlayer inputJugador;
    private Transform transformada;
    private float horizontal;
    private float vertical;
    [SerializeField] private float velocidad; // Para mostrarlo en el proyecto
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Le agregamos el metodo InputPlayer como componente a nuestro objeto
        // inputJugador
        inputJugador = GetComponent<InputPlayer>();
        // Se hace lo mismo con Transform
        transformada = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() // GameLogic
    {
        // Asignamos nuestras variables de direccion a las que recibamos del
        // InputPlayer que interactua con el usuario
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;
    }

    // Update is called once per frame
    void FixedUpdate() // PHYSICS
    {
        
        // Guardaremos la posicion que toma el jugador por cada frame en nuevaPosicion
        // dependiendo lo que se obtiene de InputPlayer y la velocidad del player
        //Vector2 nuevaPosicion = transformada.position + new Vector3(velocidad *
        //    horizontal * Time.deltaTime, velocidad * vertical * Time.deltaTime, 0);
        //transformada.position = nuevaPosicion;

        //========= Movimientos =========//
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocidad;
        rb.velocity = vectorVelocidad;
    }
}
