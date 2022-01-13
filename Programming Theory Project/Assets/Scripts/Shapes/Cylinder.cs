using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : Shape
{
    public RectTransform textPanel;
    public Text textInfo;

    public string Name { get; private set; }
    public Color Color { get; private set; }

    private void OnMouseEnter()
    {       
        DisplayText();

        // Inheritance - We do not need a reference to the class we call this function from since
        // We are inheriting from the caller class
        StartCoroutine(DelayedPanel(textPanel.gameObject));
    }

    private void OnMouseExit()
    {
        textPanel.gameObject.SetActive(false);
    }

    // Set the position of the text panel to be the tip of the mouse cursor
    private void OnMouseOver()
    {
        textPanel.transform.position = new Vector2(Input.mousePosition.x + textPanel.sizeDelta.x / 2,
                                                   Input.mousePosition.y + textPanel.sizeDelta.y / 2);
    }

    #region Polymorphism
    public override void DisplayText()
    {
        base.DisplayText();

        Name = ShapeName;
        Color = ShapeColor;

        textInfo.text = "This is a: " + Name + "\nIts color is: " + GetShapeColor(Color);
    }
    #endregion
}
