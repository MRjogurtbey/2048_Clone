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
        for (int i = 0; i < 16; i++)
        {
            GameObject newCell = Instantiate(cellPrefab, boardTransform);

            int index = i + 1;
            newCell.name = $"Cell_{index:D3}";
        }
    }
}