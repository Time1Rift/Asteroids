using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private Transform _container;

    private List<Presenter> _pool = new();
    private Presenter _result;

    public void SetObgect(Presenter item) => item.gameObject.SetActive(false);

    protected Presenter GetObject(Presenter prefab)
    {
        _result = _pool.FirstOrDefault(item => item.gameObject.activeSelf == false && item.Type == prefab.Type);

        if (_result == null)
        {
            _result = Instantiate(prefab, _container);
            _pool.Add(_result);
        }

        _result.gameObject.SetActive(true);
        return _result;
    }
}