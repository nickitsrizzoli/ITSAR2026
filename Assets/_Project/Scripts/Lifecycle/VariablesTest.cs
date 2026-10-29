
using System;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    #region Incapsulamento

    [SerializeField] private int shopIndex = 0;

    public int ShopIndexbis
    {
        get => shopIndex;
        private set => shopIndex = value;
    }

    public int ShopIndex => shopIndex;

    public void setshopIndexValue(int _shopIndex)
    {
        if(shopstateBase != ShopState.CLOSING)
        {
            shopIndex=_shopIndex;
        }
    }

    #endregion

    [SerializeField] private float shopRevenue = 50.5f;
    [SerializeField] private bool shopOpen = false;

    public enum ShopState
    {
        OPENING = 0,
        SELLING,
        RESTOCKING,
        CLOSING
    }

    [SerializeField] private ShopState shopstateBase = ShopState.OPENING;
    [SerializeField] private ShopState shopstateAdvanced = ShopState.RESTOCKING;

    [SerializeField] private string shopName = "shop";

    [SerializeField] private int[] productArray = new int[5];

    [SerializeField] private List<int> productList = new List<int>();

    [SerializeField] private List<Product> productsList = new List<Product>();

    private HashSet<Product> productHashSet = new HashSet<Product>();

    private Dictionary<string, float> productDictionary =
        new Dictionary<string, float>();

    [Serializable]
    public class Product
    {
        public string Name;
        public float Price;
    }
}
