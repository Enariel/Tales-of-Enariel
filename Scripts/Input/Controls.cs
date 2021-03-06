// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""170e1884-73a9-4f6a-991d-d1e069e9147a"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""04adef75-37ea-43b1-9711-640f7b9caa83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""f4d00d4f-12d0-4e6f-be47-7bc2837aff99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Value"",
                    ""id"": ""f2b10fc0-ac38-4b85-a0d9-321f3f401934"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Item"",
                    ""type"": ""Value"",
                    ""id"": ""db67462b-e8fe-4113-98f4-cc7441ce013e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Walk_WASD"",
                    ""id"": ""b42d9bdf-1aad-44c3-a508-dabf44ca5df1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3a711673-ee25-4420-a9ee-e009faef1050"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""49714304-94ff-4ebb-9fca-d35c1c30d8cb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b71d7fdd-4f55-4320-85d9-5e8d7ceed182"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""faf75b6b-c4ec-4d1d-ad8e-bc46173ab912"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ab2493b-7114-473e-b93e-a300e79bfb5e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fb4e6782-04f3-4053-8f27-1d9b5640d396"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53866531-ef0a-4b88-8536-799f76e0882b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e578d1a2-ecd8-47fc-a9d7-9bed784af615"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8a4372fb-a51f-424c-8f21-200018a1e702"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""53543124-b4c0-4631-a96e-1149da25daea"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb4fe63e-0fd3-4af8-9bb0-eedf22758df4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Combat"",
            ""id"": ""94dd7c80-5fc1-4b6e-a88a-168ace332296"",
            ""actions"": [
                {
                    ""name"": ""LoadSpell1"",
                    ""type"": ""Button"",
                    ""id"": ""a3460344-fb14-4f9e-aa2d-15256319edde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LoadSpell2"",
                    ""type"": ""Button"",
                    ""id"": ""f3ab3509-459f-46dc-b707-b31a49d8b25e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LoadSpell3"",
                    ""type"": ""Button"",
                    ""id"": ""79edae2a-f221-4adc-b24c-243d30298dee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LoadSpell4"",
                    ""type"": ""Button"",
                    ""id"": ""f241bcaa-9bb5-4a78-93f3-09ae3d5e1c20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleHotBar"",
                    ""type"": ""Button"",
                    ""id"": ""daa55745-4613-4871-a9dc-93139ff6988c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6de486ce-18c7-4513-993b-02de2c9e9533"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""80521500-db4b-44bf-b7dd-baac62eba99a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LoadSpell1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d541bae8-46cc-41da-af93-df4693bc32ec"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LoadSpell2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""151ad947-60c8-4c35-9a8e-0ac16c3a09c7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LoadSpell3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45daa87e-e401-444b-a284-f41c4332c794"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LoadSpell4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbc20b4b-6d52-4faa-8775-c7eb08e03740"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleHotBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5da759c-e37a-418b-ae99-528dfecaa35f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""5d1ab0bd-c3a0-486e-aca1-e3397d28db81"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""81810e0b-bca6-47e4-9e3d-7be9ad9e93e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left_Click"",
                    ""type"": ""Button"",
                    ""id"": ""08513324-fe05-478f-b604-6d99463fef3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right_Click"",
                    ""type"": ""Button"",
                    ""id"": ""5b068492-b595-46e5-aa32-620c6700cd29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""35349391-bd24-4c9b-be7b-230cc026aee6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""66793a40-c4c7-4eb6-b93f-fa8e04b18e34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""461edd91-0f8e-45af-8ebd-530752c39268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4d87b94-5047-4d80-9374-d7e178493ebe"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0b23987-613c-4055-9fe0-63c89df50aac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7be41779-8075-4f0e-b772-4571e2b53357"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78d19dc7-fdb7-4248-b7a8-4b89e908d3b4"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3964ece4-4785-4b87-99d1-646aaf1a55ea"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0a5202c-3255-41cc-b3dc-72bbca94926c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Walk = m_Movement.FindAction("Walk", throwIfNotFound: true);
        m_Movement_Run = m_Movement.FindAction("Run", throwIfNotFound: true);
        m_Movement_Interact = m_Movement.FindAction("Interact", throwIfNotFound: true);
        m_Movement_UseItem = m_Movement.FindAction("Use Item", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_LoadSpell1 = m_Combat.FindAction("LoadSpell1", throwIfNotFound: true);
        m_Combat_LoadSpell2 = m_Combat.FindAction("LoadSpell2", throwIfNotFound: true);
        m_Combat_LoadSpell3 = m_Combat.FindAction("LoadSpell3", throwIfNotFound: true);
        m_Combat_LoadSpell4 = m_Combat.FindAction("LoadSpell4", throwIfNotFound: true);
        m_Combat_ToggleHotBar = m_Combat.FindAction("ToggleHotBar", throwIfNotFound: true);
        m_Combat_Attack = m_Combat.FindAction("Attack", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Left_Click = m_UI.FindAction("Left_Click", throwIfNotFound: true);
        m_UI_Right_Click = m_UI.FindAction("Right_Click", throwIfNotFound: true);
        m_UI_Scroll = m_UI.FindAction("Scroll", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Walk;
    private readonly InputAction m_Movement_Run;
    private readonly InputAction m_Movement_Interact;
    private readonly InputAction m_Movement_UseItem;
    public struct MovementActions
    {
        private @Controls m_Wrapper;
        public MovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Movement_Walk;
        public InputAction @Run => m_Wrapper.m_Movement_Run;
        public InputAction @Interact => m_Wrapper.m_Movement_Interact;
        public InputAction @UseItem => m_Wrapper.m_Movement_UseItem;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Interact.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                @UseItem.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnUseItem;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_LoadSpell1;
    private readonly InputAction m_Combat_LoadSpell2;
    private readonly InputAction m_Combat_LoadSpell3;
    private readonly InputAction m_Combat_LoadSpell4;
    private readonly InputAction m_Combat_ToggleHotBar;
    private readonly InputAction m_Combat_Attack;
    public struct CombatActions
    {
        private @Controls m_Wrapper;
        public CombatActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LoadSpell1 => m_Wrapper.m_Combat_LoadSpell1;
        public InputAction @LoadSpell2 => m_Wrapper.m_Combat_LoadSpell2;
        public InputAction @LoadSpell3 => m_Wrapper.m_Combat_LoadSpell3;
        public InputAction @LoadSpell4 => m_Wrapper.m_Combat_LoadSpell4;
        public InputAction @ToggleHotBar => m_Wrapper.m_Combat_ToggleHotBar;
        public InputAction @Attack => m_Wrapper.m_Combat_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @LoadSpell1.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell1;
                @LoadSpell1.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell1;
                @LoadSpell1.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell1;
                @LoadSpell2.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell2;
                @LoadSpell2.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell2;
                @LoadSpell2.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell2;
                @LoadSpell3.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell3;
                @LoadSpell3.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell3;
                @LoadSpell3.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell3;
                @LoadSpell4.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell4;
                @LoadSpell4.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell4;
                @LoadSpell4.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLoadSpell4;
                @ToggleHotBar.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnToggleHotBar;
                @ToggleHotBar.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnToggleHotBar;
                @ToggleHotBar.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnToggleHotBar;
                @Attack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LoadSpell1.started += instance.OnLoadSpell1;
                @LoadSpell1.performed += instance.OnLoadSpell1;
                @LoadSpell1.canceled += instance.OnLoadSpell1;
                @LoadSpell2.started += instance.OnLoadSpell2;
                @LoadSpell2.performed += instance.OnLoadSpell2;
                @LoadSpell2.canceled += instance.OnLoadSpell2;
                @LoadSpell3.started += instance.OnLoadSpell3;
                @LoadSpell3.performed += instance.OnLoadSpell3;
                @LoadSpell3.canceled += instance.OnLoadSpell3;
                @LoadSpell4.started += instance.OnLoadSpell4;
                @LoadSpell4.performed += instance.OnLoadSpell4;
                @LoadSpell4.canceled += instance.OnLoadSpell4;
                @ToggleHotBar.started += instance.OnToggleHotBar;
                @ToggleHotBar.performed += instance.OnToggleHotBar;
                @ToggleHotBar.canceled += instance.OnToggleHotBar;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Left_Click;
    private readonly InputAction m_UI_Right_Click;
    private readonly InputAction m_UI_Scroll;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    public struct UIActions
    {
        private @Controls m_Wrapper;
        public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Left_Click => m_Wrapper.m_UI_Left_Click;
        public InputAction @Right_Click => m_Wrapper.m_UI_Right_Click;
        public InputAction @Scroll => m_Wrapper.m_UI_Scroll;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Left_Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLeft_Click;
                @Left_Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLeft_Click;
                @Left_Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLeft_Click;
                @Right_Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRight_Click;
                @Right_Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRight_Click;
                @Right_Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRight_Click;
                @Scroll.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Left_Click.started += instance.OnLeft_Click;
                @Left_Click.performed += instance.OnLeft_Click;
                @Left_Click.canceled += instance.OnLeft_Click;
                @Right_Click.started += instance.OnRight_Click;
                @Right_Click.performed += instance.OnRight_Click;
                @Right_Click.canceled += instance.OnRight_Click;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IMovementActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnLoadSpell1(InputAction.CallbackContext context);
        void OnLoadSpell2(InputAction.CallbackContext context);
        void OnLoadSpell3(InputAction.CallbackContext context);
        void OnLoadSpell4(InputAction.CallbackContext context);
        void OnToggleHotBar(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnLeft_Click(InputAction.CallbackContext context);
        void OnRight_Click(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
