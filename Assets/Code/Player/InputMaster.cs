//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Code/Player/InputMaster.inputactions
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

public partial class @InputMaster: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""7d8174da-c1dd-482e-a65f-99aadaa1bfb5"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fdd83852-2506-4f77-85c8-86073a7ff2f6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""744cf49e-410a-4963-adb7-e0c7365a3a41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8776396d-4ea3-4de8-ba43-7d4f878c1efe"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18fa1ccf-2dff-4daf-909c-d96008230fd5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae609dd4-7970-4302-b02d-0f3f575624db"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c440eda7-bf1d-460d-b2e7-4d884377483d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""325400b3-9b35-4516-95b5-c86c6b5da193"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9b5806c0-d436-43f1-a8fc-52ec334abc2e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""c82b9cdc-4a8d-4d4c-b636-17f064c990fa"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f8ec2b37-03f1-4663-b786-097462ac8481"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11b2ff80-b9d0-4670-afcc-58b0b62fd778"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shooter"",
            ""id"": ""885fed3d-8d19-428f-9fd5-e2facbb4d0fc"",
            ""actions"": [
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""8ab2080b-a959-4025-9b33-466a7c68b333"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""736f31a1-e018-4aee-96a5-48369b83c98b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ADS"",
                    ""type"": ""Button"",
                    ""id"": ""172a0136-5b22-4c1f-96df-48704a4a9a58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponScroll"",
                    ""type"": ""Value"",
                    ""id"": ""278eeb45-16c8-4a15-805a-3c235fb8f1f3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pick Up"",
                    ""type"": ""Button"",
                    ""id"": ""c48d54db-4537-4ef9-9779-46f29643048a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef2d4b04-3f3f-4f46-a700-047cd8f7cf57"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0439a67-e3f5-4637-b4dc-7cc4e1f67536"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48844dd0-2f2b-4487-8b32-b90b56c5c84b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""ADS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61985644-c0aa-49f9-9ee9-862c53cee248"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""WeaponScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72523eeb-099e-436c-b9e4-9c98742f977e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""M&K"",
                    ""action"": ""Pick Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""c3b83d35-d109-4170-9583-856390326c3e"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a4a17f89-2bdc-47af-8421-2da88affdd2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cc3e8ca-fc08-4adb-b40f-32afb9c54fa9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""M&K"",
            ""bindingGroup"": ""M&K"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Direction = m_Movement.FindAction("Direction", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
        // Shooter
        m_Shooter = asset.FindActionMap("Shooter", throwIfNotFound: true);
        m_Shooter_Reload = m_Shooter.FindAction("Reload", throwIfNotFound: true);
        m_Shooter_Shoot = m_Shooter.FindAction("Shoot", throwIfNotFound: true);
        m_Shooter_ADS = m_Shooter.FindAction("ADS", throwIfNotFound: true);
        m_Shooter_WeaponScroll = m_Shooter.FindAction("WeaponScroll", throwIfNotFound: true);
        m_Shooter_PickUp = m_Shooter.FindAction("Pick Up", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Pause = m_Menu.FindAction("Pause", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Direction;
    private readonly InputAction m_Movement_Jump;
    public struct MovementActions
    {
        private @InputMaster m_Wrapper;
        public MovementActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_Movement_Direction;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Direction.started += instance.OnDirection;
            @Direction.performed += instance.OnDirection;
            @Direction.canceled += instance.OnDirection;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Direction.started -= instance.OnDirection;
            @Direction.performed -= instance.OnDirection;
            @Direction.canceled -= instance.OnDirection;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
    private readonly InputAction m_Camera_Look;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Camera_Look;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void AddCallbacks(ICameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(ICameraActions instance)
        {
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Shooter
    private readonly InputActionMap m_Shooter;
    private List<IShooterActions> m_ShooterActionsCallbackInterfaces = new List<IShooterActions>();
    private readonly InputAction m_Shooter_Reload;
    private readonly InputAction m_Shooter_Shoot;
    private readonly InputAction m_Shooter_ADS;
    private readonly InputAction m_Shooter_WeaponScroll;
    private readonly InputAction m_Shooter_PickUp;
    public struct ShooterActions
    {
        private @InputMaster m_Wrapper;
        public ShooterActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Reload => m_Wrapper.m_Shooter_Reload;
        public InputAction @Shoot => m_Wrapper.m_Shooter_Shoot;
        public InputAction @ADS => m_Wrapper.m_Shooter_ADS;
        public InputAction @WeaponScroll => m_Wrapper.m_Shooter_WeaponScroll;
        public InputAction @PickUp => m_Wrapper.m_Shooter_PickUp;
        public InputActionMap Get() { return m_Wrapper.m_Shooter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShooterActions set) { return set.Get(); }
        public void AddCallbacks(IShooterActions instance)
        {
            if (instance == null || m_Wrapper.m_ShooterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShooterActionsCallbackInterfaces.Add(instance);
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ADS.started += instance.OnADS;
            @ADS.performed += instance.OnADS;
            @ADS.canceled += instance.OnADS;
            @WeaponScroll.started += instance.OnWeaponScroll;
            @WeaponScroll.performed += instance.OnWeaponScroll;
            @WeaponScroll.canceled += instance.OnWeaponScroll;
            @PickUp.started += instance.OnPickUp;
            @PickUp.performed += instance.OnPickUp;
            @PickUp.canceled += instance.OnPickUp;
        }

        private void UnregisterCallbacks(IShooterActions instance)
        {
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ADS.started -= instance.OnADS;
            @ADS.performed -= instance.OnADS;
            @ADS.canceled -= instance.OnADS;
            @WeaponScroll.started -= instance.OnWeaponScroll;
            @WeaponScroll.performed -= instance.OnWeaponScroll;
            @WeaponScroll.canceled -= instance.OnWeaponScroll;
            @PickUp.started -= instance.OnPickUp;
            @PickUp.performed -= instance.OnPickUp;
            @PickUp.canceled -= instance.OnPickUp;
        }

        public void RemoveCallbacks(IShooterActions instance)
        {
            if (m_Wrapper.m_ShooterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShooterActions instance)
        {
            foreach (var item in m_Wrapper.m_ShooterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShooterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShooterActions @Shooter => new ShooterActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_Pause;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Menu_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_MKSchemeIndex = -1;
    public InputControlScheme MKScheme
    {
        get
        {
            if (m_MKSchemeIndex == -1) m_MKSchemeIndex = asset.FindControlSchemeIndex("M&K");
            return asset.controlSchemes[m_MKSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IShooterActions
    {
        void OnReload(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnADS(InputAction.CallbackContext context);
        void OnWeaponScroll(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
