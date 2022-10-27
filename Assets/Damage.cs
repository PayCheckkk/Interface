using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _currentValue;
    private float _targetValue;
    private float _damage = 10;

    private void Update()
    {
        _currentValue = _slider.value;
        _targetValue = _currentValue - _damage;
    }

    public void OnButtonClick()
    {
        _slider.DOValue(_targetValue, 0.3f);
        _currentValue = _targetValue;
        Debug.Log(_slider.value);
    }
}
