using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class HeadsetDetector : MonoBehaviour
{
    private InputDeviceCharacteristics headsetCharacteristic = InputDeviceCharacteristics.HeadMounted;
    private XRDeviceSimulator simulator;

    private void Awake()
    {
        simulator = GetComponent<XRDeviceSimulator>();
        simulator.enabled = true;
    }

    private void OnEnable()
    {
        InputDevices.deviceConnected += TurnOffSimulatorIfHMD;
        InputDevices.deviceDisconnected += TurnOnSimulatorIfHMD;
    }

    private void OnDisable()
    {
        InputDevices.deviceConnected -= TurnOffSimulatorIfHMD;
        InputDevices.deviceDisconnected -= TurnOnSimulatorIfHMD;
    }

    private void TurnOffSimulatorIfHMD(InputDevice device)
    {
        if (!device.characteristics.HasFlag(headsetCharacteristic))
            return;
        simulator.enabled = false;
    }

    private void TurnOnSimulatorIfHMD(InputDevice device)
    {
        if (!device.characteristics.HasFlag(headsetCharacteristic))
            return;
        simulator.enabled = true;
    }
}

//SOURCE: https://gist.github.com/efagerberg/9ffe57a13bb9fce6cec5f46951c13040