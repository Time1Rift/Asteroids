using System;
using UnityEngine;

public class ShipPresenter : Presenter
{
    public event Action ShipDisabled;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out EnemyPresenter enemy))
            ShipDisabled?.Invoke();
    }
}