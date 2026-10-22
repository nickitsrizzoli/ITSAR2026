using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Tooltip("Velocità di rotazione in gradi al secondo")]
    [SerializeField] private float speed = 90f;

    // configurabile anche l'asse di rotazione
    [Tooltip("Asse di rotazione (es. (0,1,0) = Y, (1,0,0) = X, (0,0,1) = Z)")]
    [SerializeField] private Vector3 axis = Vector3.up;

    [Tooltip("Self = asse locale dell'oggetto, World = asse del mondo")]
    [SerializeField] private Space space = Space.Self;

    void Update()
    {
        // Time.deltaTime rende la rotazione indipendente dal framerate
        transform.Rotate(axis.normalized * (speed * Time.deltaTime), space);
    }
}