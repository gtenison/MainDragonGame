using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;
    private Dictionary<string, int> resources = new Dictionary<string, int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddResources(string type, int amount)
    {
        if (!resources.ContainsKey(type))
        {
            resources[type] = 0;
        }

        resources[type] += amount; 
    }

    public bool SpendResources(string type, int amount)
    {
        if (resources.ContainsKey(type) && resources[type] >= amount)
        {
            resources[type] -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetResources(string type)
    {
        if (resources.ContainsKey(type))
        {
            return resources[type];
        }
        else
        {
            return 0;
        }
    }
}
