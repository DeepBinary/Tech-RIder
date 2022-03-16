using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Diffuculty { Easy, Medium, Expert, Master, GrandMaster, God }

[CreateAssetMenu(fileName ="Level", menuName = "Level")]
public class Level : ScriptableObject
{
    public int index;
    public Sprite thumbnail;
    public Diffuculty Difficulty;
}
