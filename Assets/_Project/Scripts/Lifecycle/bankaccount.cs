
using UnityEngine;

public class bankaccount : MonoBehaviour
{
    [SerializeField] int containedvalue;
    public int bankvalue=> containedvalue;

    public void AddMoneyToBank(int money)
    {
        containedvalue += money;
    }
}
