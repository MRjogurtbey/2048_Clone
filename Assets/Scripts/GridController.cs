using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class GridController : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private Cell cellPrefab;
    [SerializeField] private Tile tilePrefab; // TilePrefab'ını buraya sürükle
    [SerializeField] private Transform boardTransform;
    [SerializeField] private TileSettings settings; // ScriptableObject dosyan
    
    private List<Cell> _cells = new List<Cell>();
    
    
    private void Start()
    {
        GenerateGrid();
        
        SpawnRandomTile();
        SpawnRandomTile();
    }

    private void GenerateGrid()
    {
        for (int i = 0; i < 16; i++)
        {
            Cell newCell = Instantiate(cellPrefab, boardTransform);

            int index = i + 1;
            newCell.name = $"Cell_{index:D3}";

            // Koordinatları veriyoruz (i % 4 = X, i / 4 = Y)
            newCell.SetCoordinates(i % 4, i / 4);
        
            // Listeye ekliyoruz
            _cells.Add(newCell);
        }
    }
    public void SpawnRandomTile()
    {
        var emptyCells = _cells.Where(c => c.IsEmpty).ToList();

        if (emptyCells.Count > 0)
        {
            Cell targetCell = emptyCells[Random.Range(0, emptyCells.Count)];

            // Doğrudan Tile tipinde oluşturuyoruz
            Tile newTile = Instantiate(tilePrefab, targetCell.transform);
            newTile.transform.SetAsLastSibling();
            int value = Random.value > 0.9f ? 4 : 2;
            newTile.SetValue(value, settings);

            targetCell.OccupiedTile = newTile;
        }
    }
}