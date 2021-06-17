using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapClicker : MonoBehaviour
{
    public TileBase tileToSet;
    private Tilemap map;
    private Camera mainCamera;
    void Start()
    {
        map = GetComponent<Tilemap>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int clickCellPos = map.WorldToCell(clickWorldPos);

            Debug.Log(clickCellPos);
        }
    }
}
