using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public event UnityAction<float> HealthChanged;

    private float _health = 50;
    private float _maxHealth = 100;
    private float _minHealth = 0;
    
    public float GetHealth => _health;
    public float GetMaxHealth => _maxHealth;

    public void Damage(float value)
    {
        _health = Mathf.Clamp(_health - value, _minHealth, _maxHealth);

        HealthChanged.Invoke(_health);
    }

    public void Heal(float value)
    {
        _health = Mathf.Clamp(_health + value, _minHealth, _maxHealth);

        HealthChanged.Invoke(_health);
    }
}
