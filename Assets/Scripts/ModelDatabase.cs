using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Model Database", menuName = "Assets/Databases/Model Database")]

public class ItemDatabase : ScriptableObject {
    public List<Model> allModels;
}
