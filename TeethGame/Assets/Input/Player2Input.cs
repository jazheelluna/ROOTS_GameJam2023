//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/Player2Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player2Input : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player2Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player2Input"",
    ""maps"": [
        {
            ""name"": ""Player2"",
            ""id"": ""1102a384-a568-4b8a-8d7f-514d4d1ba243"",
            ""actions"": [
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""4db30984-7e05-4819-88e6-d60d7d86e7fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Gyro"",
                    ""type"": ""PassThrough"",
                    ""id"": ""83f77cc1-e297-4e8f-851b-3eeb2d3fa86b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ef7887a-4dca-447a-bd94-feb603753f5b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fd27b43-fdf5-4185-8762-e6e58e03f9ec"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d57f885-80b0-4f23-850a-78c4ad87139a"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gyro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Open = m_Player2.FindAction("Open", throwIfNotFound: true);
        m_Player2_Gyro = m_Player2.FindAction("Gyro", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Open;
    private readonly InputAction m_Player2_Gyro;
    public struct Player2Actions
    {
        private @Player2Input m_Wrapper;
        public Player2Actions(@Player2Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Open => m_Wrapper.m_Player2_Open;
        public InputAction @Gyro => m_Wrapper.m_Player2_Gyro;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Open.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOpen;
                @Gyro.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGyro;
                @Gyro.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGyro;
                @Gyro.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGyro;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
                @Gyro.started += instance.OnGyro;
                @Gyro.performed += instance.OnGyro;
                @Gyro.canceled += instance.OnGyro;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer2Actions
    {
        void OnOpen(InputAction.CallbackContext context);
        void OnGyro(InputAction.CallbackContext context);
    }
}