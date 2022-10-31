using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public UnityEvent<float> HealthChanged;
    private float _health = 50;
    private float _maxHealth = 100;
    private float _minHealth = 0;
    
    public float GetHealth => _health;
    public float GetMaxHealth => _maxHealth;

    public void Damage()
    {
        float damage = 10;

        if (_health >= damage)
            _health -= damage;
        else
            _health = _minHealth;

        HealthChanged.Invoke(_health);
    }

    public void Heal()
    {
        float heal = 10;

        if ((_maxHealth - _health) <= heal)
            _health = _maxHealth;
        else
            _health += heal;

        HealthChanged.Invoke(_health);
    }
}
