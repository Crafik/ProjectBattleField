//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controls/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Desktop"",
            ""id"": ""1a36b5ee-cbc4-44bb-a7f3-923c2e61c5fe"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f162dd8d-abbf-4abc-866f-5b88ed7cb570"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""89d5567a-63d0-4ade-a266-89eccabb2573"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLMB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f5ff183-b91a-4670-b9ab-9f69f48d77db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""79bca80e-a314-4b38-97cc-1851fcd6e0b7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ccefcc7a-d6b2-48cb-bfef-9487d216f830"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ee0aa309-0228-4557-a8b3-e57a36a88847"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""59a7a49e-cae3-432e-ab2f-a3a9c2aa42f7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a350dc3d-4728-43bb-a99c-cd73142414dd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6f0c3cf4-9787-4d78-ac82-2d40fda8352b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3f49e06-d784-4649-b56e-0f709c918d8d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Desktop
        m_Desktop = asset.FindActionMap("Desktop", throwIfNotFound: true);
        m_Desktop_Move = m_Desktop.FindAction("Move", throwIfNotFound: true);
        m_Desktop_MouseDelta = m_Desktop.FindAction("MouseDelta", throwIfNotFound: true);
        m_Desktop_MouseLMB = m_Desktop.FindAction("MouseLMB", throwIfNotFound: true);
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

    // Desktop
    private readonly InputActionMap m_Desktop;
    private List<IDesktopActions> m_DesktopActionsCallbackInterfaces = new List<IDesktopActions>();
    private readonly InputAction m_Desktop_Move;
    private readonly InputAction m_Desktop_MouseDelta;
    private readonly InputAction m_Desktop_MouseLMB;
    public struct DesktopActions
    {
        private @Controls m_Wrapper;
        public DesktopActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Desktop_Move;
        public InputAction @MouseDelta => m_Wrapper.m_Desktop_MouseDelta;
        public InputAction @MouseLMB => m_Wrapper.m_Desktop_MouseLMB;
        public InputActionMap Get() { return m_Wrapper.m_Desktop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesktopActions set) { return set.Get(); }
        public void AddCallbacks(IDesktopActions instance)
        {
            if (instance == null || m_Wrapper.m_DesktopActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DesktopActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @MouseDelta.started += instance.OnMouseDelta;
            @MouseDelta.performed += instance.OnMouseDelta;
            @MouseDelta.canceled += instance.OnMouseDelta;
            @MouseLMB.started += instance.OnMouseLMB;
            @MouseLMB.performed += instance.OnMouseLMB;
            @MouseLMB.canceled += instance.OnMouseLMB;
        }

        private void UnregisterCallbacks(IDesktopActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @MouseDelta.started -= instance.OnMouseDelta;
            @MouseDelta.performed -= instance.OnMouseDelta;
            @MouseDelta.canceled -= instance.OnMouseDelta;
            @MouseLMB.started -= instance.OnMouseLMB;
            @MouseLMB.performed -= instance.OnMouseLMB;
            @MouseLMB.canceled -= instance.OnMouseLMB;
        }

        public void RemoveCallbacks(IDesktopActions instance)
        {
            if (m_Wrapper.m_DesktopActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDesktopActions instance)
        {
            foreach (var item in m_Wrapper.m_DesktopActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DesktopActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DesktopActions @Desktop => new DesktopActions(this);
    public interface IDesktopActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnMouseLMB(InputAction.CallbackContext context);
    }
}
