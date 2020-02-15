using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _inventoryElements;

    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        if(_inventoryElements == null || !_inventoryElements.Any())
        {
            Debug.LogError("Error => No elements in inventory.");
            Destroy(this);
        }

        foreach (GameObject inventoryElement in _inventoryElements)
            inventoryElement.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ElementAcquired(int index)
    {
        if (index < 0 || index >= _inventoryElements.Length)
            return;

        _inventoryElements[index].SetActive(true);

        _score++;

        if(_score == _inventoryElements.Length)
        {
            StartCoroutine(EndGameCoroutine());
        }
    }

    private IEnumerator EndGameCoroutine()
    {
        yield return new WaitForSecondsRealtime(4f);
        
        //SceneManager.LoadScene("");
    }
}
