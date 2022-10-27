using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Heal : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _targetValue;
    private float _heal = 10;

    private void Update()
    {
        _targetValue = _slider.value + _heal;
    }

    public void OnButtonClick()
    {
        _slider.DOValue(_targetValue, 0.3f);
        Debug.Log(_slider.value);
    }
}
