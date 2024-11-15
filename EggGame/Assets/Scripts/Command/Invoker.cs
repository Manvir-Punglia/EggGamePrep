using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    
    private SortedList<float, Command> _recordedCommands =
        new SortedList<float, Command>();
    
    
    public void ExecuteCommand(Command command)
    {
        command.Execute();
        Debug.unityLogger.Log(command.ToString());
    }
}
