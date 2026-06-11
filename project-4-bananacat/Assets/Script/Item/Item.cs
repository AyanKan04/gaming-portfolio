using UnityEngine;

public class Item : MonoBehaviour
{
    public int tier; 

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public int GetValue()
    {
        return ItemManager.Instance.GetValue(tier);
    }

    public int GetRequiredLevel()
    {
        return ItemManager.Instance.GetRequiredLevel(tier);
    }

    public Vector3 GetOriginalScale()
    {
        return originalScale;
    }
}