using UnityEngine;

public class visibilyTest : MonoBehaviour
{
    [SerializeField] VariablesTest vt;

    private void Start()
    {
        if (vt != null)
        {
            Debug.Log($"{vt.ShopIndex}");
        }
    }
}