using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TierData
{
    public int requiredLevel;
    public int value;
}
public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public List<TierData> tiers;

    void Awake()
    {
        Instance = this;
    }

    public int GetValue(int tier)
    {
        return tiers[tier].value;
    }

    public int GetRequiredLevel(int tier)
    {
        return tiers[tier].requiredLevel;
    }
}
