using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Slider expSlider;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI expText;

    public void UpdateUI(int level, int exp, int expToNext)
    {
        expSlider.maxValue = expToNext;
        expSlider.value = exp;

        levelText.text = level.ToString();
        expText.text = exp + " / " + expToNext;
    }
}