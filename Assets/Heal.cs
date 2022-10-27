using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Heal : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _currentValue;
    private float _targetValue;
    private float _heal = 10;

    private void Update()
    {
        _currentValue = _slider.value;
        _targetValue = _currentValue + _heal;
    }

    public void OnButtonClick()
    {
        _slider.DOValue(_targetValue, 0.3f);
        _currentValue = _targetValue;
        Debug.Log(_slider.value);
    }
}