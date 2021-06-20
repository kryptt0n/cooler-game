using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapClicker : MonoBehaviour
{
    public TileBase tileToSet1, tileToSet2, tileBoard;
    private Tilemap map;
    private Camera mainCamera;
    public Transform Player1, Player2;
    private bool fpMove = true;
    void Start()
    {
        map = GetComponent<Tilemap>();
        mainCamera = Camera.main;
    }

    void Update()
    {   
        if (fpMove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                MovePlayer(fpMove, Player1, tileToSet1);
            }

        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                MovePlayer(fpMove, Player2, tileToSet2);
            }
        }
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            map.SwapTile(tileToSet1, null);
            map.SwapTile(tileToSet2, null);
        }
    }

    void MovePlayer(bool whichPlayer, Transform Player, TileBase tileToSet)
    {
        Vector3 click = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector3Int clickCellPos = map.WorldToCell(click);

        if (map.GetTile(clickCellPos) != tileBoard)
        {
            Player.position = map.CellToWorld(clickCellPos);
            Debug.Log(clickCellPos);
            map.FloodFill(clickCellPos, tileToSet);
            fpMove = !whichPlayer;
        }
    }
}
