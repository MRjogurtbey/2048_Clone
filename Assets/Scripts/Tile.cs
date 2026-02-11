using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 2048 karosunun (2, 4, 8...) görselini ve değerini yönetir.
/// </summary>
public class Tile : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private Image backgroundImage;

    public int Value { get; private set; }

  
    public void SetValue(int value)
    {
        Value = value;
        valueText.text = value.ToString();
        
        UpdateVisuals();
    }

    private void UpdateVisuals()
    {
        // Örnek: 2 ise sarı, 4 ise turuncu yap gibi...
    }
}