using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int xp = 0;
    [SerializeField] private int requiredXp = 100;
    [SerializeField] private int levelBase = 100;
   // [SerializeField] private List<GameObject> droids = new List<GameObject>();
    private int lvl = 1;

    public int Xp
    {
        get { return xp; }
    }

    public int RequiredXp
    {
        get { return requiredXp; }
    }

    public int LevelBase
    {
        get { return levelBase; }
    }

    public int Lvl
    {
        get { return lvl; }
    }

    /* public List<GameObject> Droids
     {
         get { return droids; }
     }*/

    // Start is called before the first frame update
    void Start()
    {
        InitLevelData();
    }


    public void AddXp(int xp)
    {
        this.xp += Mathf.Max(0, xp);
    }

  /*  public void AddDroid(GameObject droid)
    {
        droids.Add(droid);
    }*/

    private void InitLevelData()
    {
        lvl = (xp / levelBase) + 1;
        requiredXp = levelBase * lvl;
    }


}
