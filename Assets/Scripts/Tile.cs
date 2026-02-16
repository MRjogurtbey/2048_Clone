using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI valueText;

    public int Value { get; private set; }
    
    /// <summary>
    /// Tile'ın değerini ayarlar ve parent Cell'in rengini günceller.
    /// </summary>
    public void SetValue(int value, TileSettings settings)
    {
        Value = value;
        valueText.text = value.ToString();
        
        // Parent Cell'i bul ve rengini güncelle
        Cell parentCell = GetComponentInParent<Cell>();
        if (parentCell != null)
        {
            parentCell.UpdateColor(value, settings);
        }
    }
}