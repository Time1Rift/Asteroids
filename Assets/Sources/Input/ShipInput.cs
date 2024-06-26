//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Sources/Input/ShipInput.inputactions
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

public partial class @ShipInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInput"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""90e38423-d425-4846-91e1-870747c6aca5"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""a5c90b2f-06bd-404d-984f-574b2183173a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""cf0ca153-e50b-4685-ab1e-2169ab2a853c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DefaultGun"",
                    ""type"": ""Button"",
                    ""id"": ""a2c013e6-fc32-4376-a3ae-c3e767bdecc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LaserGun"",
                    ""type"": ""Button"",
                    ""id"": ""a1de5855-880e-4535-9ba3-bb6816bebeaf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""81e7d738-1b3d-4d12-8fda-8166a6b313ef"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""LaserGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86011c0d-0568-468d-b2b3-aad440042df4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e0287fd5-e1a1-4a95-bcdf-8cd21c0e2a78"",
                    ""path"": ""1DAxis(minValue=1,maxValue=-1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""123e688a-5d60-4c7d-8b79-22b4d0742a6b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""23b211d0-2e8b-48b4-a914-0c728cbc6e50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4a8a27d6-bfe1-4b55-9071-c2fe8837fa04"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""DefaultGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Rotate = m_Ship.FindAction("Rotate", throwIfNotFound: true);
        m_Ship_MoveForward = m_Ship.FindAction("MoveForward", throwIfNotFound: true);
        m_Ship_DefaultGun = m_Ship.FindAction("DefaultGun", throwIfNotFound: true);
        m_Ship_LaserGun = m_Ship.FindAction("LaserGun", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private List<IShipActions> m_ShipActionsCallbackInterfaces = new List<IShipActions>();
    private readonly InputAction m_Ship_Rotate;
    private readonly InputAction m_Ship_MoveForward;
    private readonly InputAction m_Ship_DefaultGun;
    private readonly InputAction m_Ship_LaserGun;
    public struct ShipActions
    {
        private @ShipInput m_Wrapper;
        public ShipActions(@ShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Ship_Rotate;
        public InputAction @MoveForward => m_Wrapper.m_Ship_MoveForward;
        public InputAction @DefaultGun => m_Wrapper.m_Ship_DefaultGun;
        public InputAction @LaserGun => m_Wrapper.m_Ship_LaserGun;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void AddCallbacks(IShipActions instance)
        {
            if (instance == null || m_Wrapper.m_ShipActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShipActionsCallbackInterfaces.Add(instance);
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
            @MoveForward.started += instance.OnMoveForward;
            @MoveForward.performed += instance.OnMoveForward;
            @MoveForward.canceled += instance.OnMoveForward;
            @DefaultGun.started += instance.OnDefaultGun;
            @DefaultGun.performed += instance.OnDefaultGun;
            @DefaultGun.canceled += instance.OnDefaultGun;
            @LaserGun.started += instance.OnLaserGun;
            @LaserGun.performed += instance.OnLaserGun;
            @LaserGun.canceled += instance.OnLaserGun;
        }

        private void UnregisterCallbacks(IShipActions instance)
        {
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
            @MoveForward.started -= instance.OnMoveForward;
            @MoveForward.performed -= instance.OnMoveForward;
            @MoveForward.canceled -= instance.OnMoveForward;
            @DefaultGun.started -= instance.OnDefaultGun;
            @DefaultGun.performed -= instance.OnDefaultGun;
            @DefaultGun.canceled -= instance.OnDefaultGun;
            @LaserGun.started -= instance.OnLaserGun;
            @LaserGun.performed -= instance.OnLaserGun;
            @LaserGun.canceled -= instance.OnLaserGun;
        }

        public void RemoveCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShipActions instance)
        {
            foreach (var item in m_Wrapper.m_ShipActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShipActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnMoveForward(InputAction.CallbackContext context);
        void OnDefaultGun(InputAction.CallbackContext context);
        void OnLaserGun(InputAction.CallbackContext context);
    }
}
