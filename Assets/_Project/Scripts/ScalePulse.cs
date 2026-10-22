using UnityEngine;

public class ScalePulse : MonoBehaviour
{
    [Tooltip("Moltiplicatore minimo della scala (1 = scala iniziale)")]
    [SerializeField] private float minScale = 0.8f;

    [Tooltip("Moltiplicatore massimo della scala (1 = scala iniziale)")]
    [SerializeField] private float maxScale = 1.2f;

    [Tooltip("Cicli completi (ingrandisce e diminuisce) al secondo")]
    [SerializeField] private float speed = 0.5f;

    [Tooltip("Sfasamento in secondi")]
    [SerializeField] private float timeOffset = 0f;

    private Vector3 startScale;

    void Awake()
    {
        // Scala iniziale dell'oggetto (nel tuo caso 1.1, 1.1, 1.1)
        startScale = transform.localScale;
    }

    void Update()
    {
        // Sinusoide basata sul tempo (indipendente dal framerate), normalizzata tra 0 e 1
        float wave = (Mathf.Sin((Time.time + timeOffset) * speed * Mathf.PI * 2f) + 1f) * 0.5f;

        transform.localScale = startScale * Mathf.Lerp(minScale, maxScale, wave);
    }

    void OnDisable()
    {
        // Ripristina la scala iniziale
        transform.localScale = startScale;
    }
}