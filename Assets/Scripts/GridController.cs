using UnityEngine;

public class GridController : MonoBehaviour
{
    [Header("Setup")]
    public GameObject cellPrefab; // Oluşturduğun Prefab'ı buraya sürükle
    public Transform boardTransform; // Board objesini buraya sürükle

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        // 4x4 döngü ile hücreleri oluşturur
        for (int i = 0; i < 16; i++)
        {
            // 1. Hücreyi oluştur
            GameObject newCell = Instantiate(cellPrefab, boardTransform);

            // 2. İsimlendirme mantığı: 
            // i=0 ise index=1 olur. "D3" formatı ise sayıyı 001 yapar.
            int index = i + 1;
            newCell.name = $"Cell_{index:D3}";
        }
    }
}