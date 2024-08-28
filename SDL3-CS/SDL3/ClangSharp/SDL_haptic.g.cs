/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_Haptic
    {
    }

    public partial struct SDL_HapticDirection
    {
        [NativeTypeName("Uint8")]
        public byte type;

        [NativeTypeName("Sint32[3]")]
        public _dir_e__FixedBuffer dir;

        [InlineArray(3)]
        public partial struct _dir_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct SDL_HapticConstant
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short level;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticPeriodic
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Sint16")]
        public short magnitude;

        [NativeTypeName("Sint16")]
        public short offset;

        [NativeTypeName("Uint16")]
        public ushort phase;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticCondition
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16[3]")]
        public _right_sat_e__FixedBuffer right_sat;

        [NativeTypeName("Uint16[3]")]
        public _left_sat_e__FixedBuffer left_sat;

        [NativeTypeName("Sint16[3]")]
        public _right_coeff_e__FixedBuffer right_coeff;

        [NativeTypeName("Sint16[3]")]
        public _left_coeff_e__FixedBuffer left_coeff;

        [NativeTypeName("Uint16[3]")]
        public _deadband_e__FixedBuffer deadband;

        [NativeTypeName("Sint16[3]")]
        public _center_e__FixedBuffer center;

        [InlineArray(3)]
        public partial struct _right_sat_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _left_sat_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _right_coeff_e__FixedBuffer
        {
            public short e0;
        }

        [InlineArray(3)]
        public partial struct _left_coeff_e__FixedBuffer
        {
            public short e0;
        }

        [InlineArray(3)]
        public partial struct _deadband_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _center_e__FixedBuffer
        {
            public short e0;
        }
    }

    public partial struct SDL_HapticRamp
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short start;

        [NativeTypeName("Sint16")]
        public short end;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticLeftRight
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort large_magnitude;

        [NativeTypeName("Uint16")]
        public ushort small_magnitude;
    }

    public unsafe partial struct SDL_HapticCustom
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint8")]
        public byte channels;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Uint16")]
        public ushort samples;

        [NativeTypeName("Uint16 *")]
        public ushort* data;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
        [NativeTypeName("Uint16")]
        public ushort type;

        [FieldOffset(0)]
        public SDL_HapticConstant constant;

        [FieldOffset(0)]
        public SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        public SDL_HapticCondition condition;

        [FieldOffset(0)]
        public SDL_HapticRamp ramp;

        [FieldOffset(0)]
        public SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        public SDL_HapticCustom custom;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_HapticID* SDL_GetHaptics(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetHapticNameForID(SDL_HapticID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHaptic(SDL_HapticID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_GetHapticFromID(SDL_HapticID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_HapticID SDL_GetHapticID(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetHapticName(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsMouseHaptic();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHapticFromMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsJoystickHaptic(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHapticFromJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetMaxHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetHapticFeatures(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumHapticAxes(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HapticEffectSupported(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CreateHapticEffect(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_UpdateHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_RunHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("Uint32")] uint iterations);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_StopHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetHapticGain(SDL_Haptic* haptic, int gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PauseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ResumeHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_StopHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HapticRumbleSupported(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_InitHapticRumble(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PlayHapticRumble(SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_StopHapticRumble(SDL_Haptic* haptic);

        [NativeTypeName("#define SDL_HAPTIC_CONSTANT (1u<<0)")]
        public const uint SDL_HAPTIC_CONSTANT = (1U << 0);

        [NativeTypeName("#define SDL_HAPTIC_SINE (1u<<1)")]
        public const uint SDL_HAPTIC_SINE = (1U << 1);

        [NativeTypeName("#define SDL_HAPTIC_SQUARE (1u<<2)")]
        public const uint SDL_HAPTIC_SQUARE = (1U << 2);

        [NativeTypeName("#define SDL_HAPTIC_TRIANGLE (1u<<3)")]
        public const uint SDL_HAPTIC_TRIANGLE = (1U << 3);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHUP (1u<<4)")]
        public const uint SDL_HAPTIC_SAWTOOTHUP = (1U << 4);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHDOWN (1u<<5)")]
        public const uint SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5);

        [NativeTypeName("#define SDL_HAPTIC_RAMP (1u<<6)")]
        public const uint SDL_HAPTIC_RAMP = (1U << 6);

        [NativeTypeName("#define SDL_HAPTIC_SPRING (1u<<7)")]
        public const uint SDL_HAPTIC_SPRING = (1U << 7);

        [NativeTypeName("#define SDL_HAPTIC_DAMPER (1u<<8)")]
        public const uint SDL_HAPTIC_DAMPER = (1U << 8);

        [NativeTypeName("#define SDL_HAPTIC_INERTIA (1u<<9)")]
        public const uint SDL_HAPTIC_INERTIA = (1U << 9);

        [NativeTypeName("#define SDL_HAPTIC_FRICTION (1u<<10)")]
        public const uint SDL_HAPTIC_FRICTION = (1U << 10);

        [NativeTypeName("#define SDL_HAPTIC_LEFTRIGHT (1u<<11)")]
        public const uint SDL_HAPTIC_LEFTRIGHT = (1U << 11);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED1 (1u<<12)")]
        public const uint SDL_HAPTIC_RESERVED1 = (1U << 12);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED2 (1u<<13)")]
        public const uint SDL_HAPTIC_RESERVED2 = (1U << 13);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED3 (1u<<14)")]
        public const uint SDL_HAPTIC_RESERVED3 = (1U << 14);

        [NativeTypeName("#define SDL_HAPTIC_CUSTOM (1u<<15)")]
        public const uint SDL_HAPTIC_CUSTOM = (1U << 15);

        [NativeTypeName("#define SDL_HAPTIC_GAIN (1u<<16)")]
        public const uint SDL_HAPTIC_GAIN = (1U << 16);

        [NativeTypeName("#define SDL_HAPTIC_AUTOCENTER (1u<<17)")]
        public const uint SDL_HAPTIC_AUTOCENTER = (1U << 17);

        [NativeTypeName("#define SDL_HAPTIC_STATUS (1u<<18)")]
        public const uint SDL_HAPTIC_STATUS = (1U << 18);

        [NativeTypeName("#define SDL_HAPTIC_PAUSE (1u<<19)")]
        public const uint SDL_HAPTIC_PAUSE = (1U << 19);

        [NativeTypeName("#define SDL_HAPTIC_POLAR 0")]
        public const int SDL_HAPTIC_POLAR = 0;

        [NativeTypeName("#define SDL_HAPTIC_CARTESIAN 1")]
        public const int SDL_HAPTIC_CARTESIAN = 1;

        [NativeTypeName("#define SDL_HAPTIC_SPHERICAL 2")]
        public const int SDL_HAPTIC_SPHERICAL = 2;

        [NativeTypeName("#define SDL_HAPTIC_STEERING_AXIS 3")]
        public const int SDL_HAPTIC_STEERING_AXIS = 3;

        [NativeTypeName("#define SDL_HAPTIC_INFINITY 4294967295U")]
        public const uint SDL_HAPTIC_INFINITY = 4294967295U;
    }
}
