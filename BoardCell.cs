using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoardCell : MonoBehaviour
{
    private int x, y;

    public void Initialize(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;hgjhg

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        GameManager.Instance.PlaceChess(x, y);
    }
}
