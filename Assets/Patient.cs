using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        goals.Add(s1, 3);

        base.Start();
        SubGoal s2 = new SubGoal("isTreated", 1, true);
        goals.Add(s2, 5);
    }
}
