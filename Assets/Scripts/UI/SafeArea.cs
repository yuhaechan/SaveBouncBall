using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    [SerializeField] RectTransform rect_SafeArea;
    Rect _safeArea;
    Vector2 _minAnchor;
    Vector2 _maxAnchor;

    private void Start()
    {
        PopUp_Setting();
    }

    void PopUp_Setting()
    {
        rect_SafeArea = GetComponent<RectTransform>();
        _safeArea = Screen.safeArea;

        _minAnchor = _safeArea.position;
        _maxAnchor = _minAnchor + _safeArea.size;

        _minAnchor.x /= Screen.width;
        _minAnchor.y /= Screen.height;
        _maxAnchor.x /= Screen.width;
        _maxAnchor.y /= Screen.height;

        rect_SafeArea.anchorMin = _minAnchor;
        rect_SafeArea.anchorMax = _maxAnchor;
    }


}
