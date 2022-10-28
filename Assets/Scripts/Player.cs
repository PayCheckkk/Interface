using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _health = 0;
    private float _targetHealth;

    public void ChangeHealth(float value)
    {
        _targetHealth = _health + value;
        StartCoroutine(_healthBar.ChangeHealthBar(_targetHealth));
        _health = _targetHealth;
        Debug.Log(_health);
    }

    public float OutputHealth()
    {
        return _health;
    }
}
