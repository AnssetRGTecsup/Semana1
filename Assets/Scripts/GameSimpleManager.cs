using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSimpleManager : MonoBehaviour
{
    [Header("Square Prefabs")]
    public GameObject redSquarePrefab;
    public GameObject greenSquarePrefab;
    public GameObject blueSquarePrefab;

    [Header("Circle Prefabs")]
    public GameObject redCirclePrefab;
    public GameObject greenCirclePrefab;
    public GameObject blueCirclePrefab;

    [Header("Buttons Reference")]
    public Button squareButton;
    public Button circleButton;

    public bool isSquare;
    public int color = 0; //0=Red | 1=Green | 3=Blue

    private void Start()
    {
        squareButton.onClick.AddListener(() => UpdateShape(true));
        circleButton.onClick.AddListener(() => UpdateShape(false));
    }

    public void UpdateShape(bool isSquare)
    {
        this.isSquare = isSquare;
    }

    public void UpdateNewColor(int newColor)
    {
        color = newColor;
    }

    public void UpdateNewColor(Color newColor)
    {
        if(newColor == Color.red)
        {
            color = 1;
        }else if(newColor == Color.green)
        {
            color = 2;
        }
        else
        {
            color = 3;
        }
    }

    public void CreateFigure()
    {
        if (isSquare)
        {
            if(color == 0)
            {
                Instantiate(redSquarePrefab);
            }else if(color == 1)
            {
                Instantiate(greenSquarePrefab);
            }
            else
            {
                Instantiate(blueSquarePrefab);
            }
        }
        else
        {
            if (color == 0)
            {
                Instantiate(redCirclePrefab);
            }
            else if (color == 1)
            {
                Instantiate(greenCirclePrefab);
            }
            else
            {
                Instantiate(blueCirclePrefab);
            }
        }
    }
}
