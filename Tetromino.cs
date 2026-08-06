// for all the sandard data structures that come
using UnityEngine;
// this enables us to use tiles
using UnityEngine.Tilemaps;

// making a list for all the tetrominoes
public enum Tetromino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}

[System.Serializable]
// data structure to store data for all the tetrominoes
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    // array of Vector2 for our tiles and cells
    public Vector2Int[] cells { get; private set; }
    // adding new property for Vector2 int (2D array)
    public Vector2Int[,] wallKicks { get; private set;}

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
        this.wallKicks = Data.WallKicks[this.tetromino];
    }
}
