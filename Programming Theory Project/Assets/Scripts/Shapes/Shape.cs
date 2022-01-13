using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    #region Encapsulation
    public string ShapeName { get; set; }
    public Color ShapeColor { get; set; }

    private float timeToWait = 0.5f;
    #endregion

    #region Polymorphism
    public virtual void DisplayText()
    {
        ShapeName = name;
        ShapeColor = GetComponent<Renderer>().material.color;
    }
    #endregion

    #region Abstraction & Inheritance
    // Make the object active after a small delay
    public IEnumerator DelayedPanel(GameObject panel)
    {
        yield return new WaitForSeconds(timeToWait);

        panel.SetActive(true);
    }

    /// <summary>
    /// Check whether the color we are passing in is equals to one of the colors we are checking against.
    /// If it is, return the name of the color in string format
    /// </summary>
    /// <param name="color">The color that we want to compare</param>
    /// <returns>The name of the color</returns>
    public string GetShapeColor(Color color)
    {
        string colorName = string.Empty;

        if (color == Color.red)
        {
            colorName = "Red";
        }
        else if (color == Color.blue)
        {
            colorName = "Blue";
        }
        else if (color == Color.green)
        {
            colorName = "Green";
        }

        return colorName;
    }
    #endregion
}
