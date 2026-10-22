using UnityEngine;

public class FloatMotion : MonoBehaviour
{
    [Tooltip("Ampiezza del movimento in unità: l'oggetto sale e scende di questo valore")]
    [SerializeField] private float height = 0.25f;

    [Tooltip("Cicli completi (su e giù) al secondo")]
    [SerializeField] private float speed = 0.5f;

    [Tooltip("Sfasamento in secondi")]
    [SerializeField] private float timeOffset = 0f;

    private float lastOffset;

    void OnEnable()
    {
        lastOffset = 0f;
    }

    void Update()
    {
        // Sinusoide basata sul tempo (indipendente dal framerate)
        float offset = Mathf.Sin((Time.time + timeOffset) * speed * Mathf.PI * 2f) * height;

        // Applico solo la differenza rispetto al frame precedente (asse Y del mondo),
        // così l'oggetto oscilla attorno alla posizione di partenza
        transform.position += Vector3.up * (offset - lastOffset);
        lastOffset = offset;
    }

    void OnDisable()
    {
        // Riporta l'oggetto nella posizione iniziale
        transform.position -= Vector3.up * lastOffset;
        lastOffset = 0f;
    }
}