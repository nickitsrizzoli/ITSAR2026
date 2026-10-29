using UnityEngine;

public class piggybank : MonoBehaviour
{
    [SerializeField] long moneyPerSecond = 1_000_000_000;
    [SerializeField] bankaccount bankaccount;

    double accumulator; // tiene i resti decimali tra un frame e l'altro

    void Update()
    {
        accumulator += moneyPerSecond * (double)Time.deltaTime;

        long toAdd = (long)accumulator;
        if (toAdd <= 0) return;

        accumulator -= toAdd;

        if (bankaccount)
        {
            bankaccount.AddMoneyToBank(toAdd);
            Debug.Log($"Money in the bank {bankaccount.bankvalue}");
        }
    }
}