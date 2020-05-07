using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Nuestra clase InputPlayer hereda (:) de MonoBehaviour
public class InputPlayer : MonoBehaviour
{
    // Definimos las variables de las distintas acciones que tendra el usuario
    // en el juego
    public float ejeHorizontal;
    public float ejeVertical;
    public bool atacar;
    public bool habilidad1;
    public bool habilidad2;
    public bool inventario;
    public bool interactuar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input es el objeto del cual podemos obtener los datos de entrada
        // del usuario
        // Lo que hacemos es obtener a un Boton por su nombre, los cuales
        // antes deben ser definidos en ProjectSettings->Input
        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");
        Debug.Log(inventario);

        // Obtenemos y definimos los ejes de movimiento
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");
        // Debug.Log("Axis Horizontal: " + ejeHorizontal + " | Axis Vertical: " + ejeVertical);
    }
}
