using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu()]
public class RecipeSO : ScriptableObject
{
    public List<KitchenObjectSO> kitchenObjectSOList;
    public String recipeName;
}
