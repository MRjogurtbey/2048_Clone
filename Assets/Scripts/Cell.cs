using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] private Image backgroundImage;
    
    public int X { get; private set; }
    public int Y { get; private set; }
    
    // Bu hücrenin üzerinde bir Karo (Tile) var mı? 
    // Varsa onu burada tutuyoruz, yoksa null olacak.
    public Tile OccupiedTile { get; set; }

    public void SetCoordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Yardımcı özellik: Eğer OccupiedTile null ise hücre boştur.
    public bool IsEmpty => OccupiedTile == null;
    
    /// <summary>
    /// Cell'in rengini Tile değerine göre günceller.
    /// Tile birleştiğinde veya yeni tile oluşturulduğunda çağrılır.
    /// </summary>
    public void UpdateColor(int tileValue, TileSettings settings)
    {
        if (backgroundImage == null || settings == null) return;

        // TileSettings'ten değere göre rengi bul
        foreach (var colorData in settings.Colors)
        {
            if (colorData.value == tileValue)
            {
                backgroundImage.color = colorData.color;
                return;
            }
        }
        
        // Eğer listede tanımlı bir renk yoksa varsayılan renk
        backgroundImage.color = Color.white;
    }
}