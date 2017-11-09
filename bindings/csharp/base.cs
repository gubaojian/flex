// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See the LICENSE.txt file in the project root
// for the license information.

// This file was generated by tools/generate_base.rb. Do not edit manually.

using System;
using System.Runtime.InteropServices;
using static Xamarin.Flex.NativeFunctions;

namespace Xamarin.Flex
{
    public enum Align : int
    {
        Auto = 0,
        Stretch = 1,
        Center = 2,
        Start = 3,
        End = 4,
        SpaceBetween = 5,
        SpaceAround = 6,
        SpaceEvenly = 7,
    }

    public enum Direction : int
    {
        Row = 0,
        RowReverse = 1,
        Column = 2,
        ColumnReverse = 3,
    }

    public enum Position : int
    {
        Relative = 0,
        Absolute = 1,
    }

    public enum Wrap : int
    {
        NoWrap = 0,
        Wrap = 1,
        WrapReverse = 2,
    }

    internal class NativeFunctions
    {
        const string dll_name = "flex";

        [DllImport(dll_name)] public static extern void flex_item_add (IntPtr arg1, IntPtr arg2);
        [DllImport(dll_name)] public static extern IntPtr flex_item_child (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern int flex_item_count (IntPtr arg1);
        [DllImport(dll_name)] public static extern IntPtr flex_item_delete (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_free (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_align_content (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_align_items (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_align_self (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_basis (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_bottom (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_direction (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_frame_height (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_frame_width (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_frame_x (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_frame_y (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_grow (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_height (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_justify_content (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_left (IntPtr arg1);
        [DllImport(dll_name)] public static extern IntPtr flex_item_get_managed_ptr (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_margin_bottom (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_margin_left (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_margin_right (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_margin_top (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_order (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_padding_bottom (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_padding_left (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_padding_right (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_padding_top (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_position (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_right (IntPtr arg1);
        [DllImport(dll_name)] public static extern Delegate0 flex_item_get_self_sizing (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_shrink (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_top (IntPtr arg1);
        [DllImport(dll_name)] public static extern float flex_item_get_width (IntPtr arg1);
        [DllImport(dll_name)] public static extern int flex_item_get_wrap (IntPtr arg1);
        [DllImport(dll_name)] public static extern void flex_item_insert (IntPtr arg1, int arg2, IntPtr arg3);
        [DllImport(dll_name)] public static extern IntPtr flex_item_new ();
        [DllImport(dll_name)] public static extern IntPtr flex_item_parent (IntPtr arg1);
        [DllImport(dll_name)] public static extern IntPtr flex_item_root (IntPtr arg1);
        [DllImport(dll_name)] public static extern void flex_item_set_align_content (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_align_items (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_align_self (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_basis (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_bottom (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_direction (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_grow (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_height (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_justify_content (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_left (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_managed_ptr (IntPtr arg1, IntPtr arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_margin_bottom (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_margin_left (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_margin_right (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_margin_top (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_order (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_padding_bottom (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_padding_left (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_padding_right (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_padding_top (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_position (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_right (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_self_sizing (IntPtr arg1, Delegate0 arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_shrink (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_top (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_width (IntPtr arg1, float arg2);
        [DllImport(dll_name)] public static extern void flex_item_set_wrap (IntPtr arg1, int arg2);
        [DllImport(dll_name)] public static extern void flex_layout (IntPtr arg1);

        public delegate void Delegate0 (IntPtr arg1, IntPtr arg2);
    }

    enum Properties
    {
        AlignContent,
        AlignItems,
        AlignSelf,
        Basis,
        Bottom,
        Direction,
        Grow,
        Height,
        JustifyContent,
        Left,
        MarginBottom,
        MarginLeft,
        MarginRight,
        MarginTop,
        Order,
        PaddingBottom,
        PaddingLeft,
        PaddingRight,
        PaddingTop,
        Position,
        Right,
        Shrink,
        Top,
        Width,
        Wrap,
    }

    public partial class Item
    {
        private IntPtr item = IntPtr.Zero;

        public Align AlignContent
        {
            get { return (Align)flex_item_get_align_content(item); }
            set
            {
                ValidatePropertyValue(Properties.AlignContent, (int)value);
                flex_item_set_align_content(item, (int)value);
            }
        }

        public Align AlignItems
        {
            get { return (Align)flex_item_get_align_items(item); }
            set
            {
                ValidatePropertyValue(Properties.AlignItems, (int)value);
                flex_item_set_align_items(item, (int)value);
            }
        }

        public Align AlignSelf
        {
            get { return (Align)flex_item_get_align_self(item); }
            set
            {
                ValidatePropertyValue(Properties.AlignSelf, (int)value);
                flex_item_set_align_self(item, (int)value);
            }
        }

        public float Basis
        {
            get { return flex_item_get_basis(item); }
            set
            {
                ValidatePropertyValue(Properties.Basis, value);
                flex_item_set_basis(item, value);
            }
        }

        public float Bottom
        {
            get { return flex_item_get_bottom(item); }
            set
            {
                ValidatePropertyValue(Properties.Bottom, value);
                flex_item_set_bottom(item, value);
            }
        }

        public Direction Direction
        {
            get { return (Direction)flex_item_get_direction(item); }
            set
            {
                ValidatePropertyValue(Properties.Direction, (int)value);
                flex_item_set_direction(item, (int)value);
            }
        }

        public float FrameHeight
        {
            get { return flex_item_get_frame_height(item); }
        }

        public float FrameWidth
        {
            get { return flex_item_get_frame_width(item); }
        }

        public float FrameX
        {
            get { return flex_item_get_frame_x(item); }
        }

        public float FrameY
        {
            get { return flex_item_get_frame_y(item); }
        }

        public int Grow
        {
            get { return flex_item_get_grow(item); }
            set
            {
                ValidatePropertyValue(Properties.Grow, value);
                flex_item_set_grow(item, value);
            }
        }

        public float Height
        {
            get { return flex_item_get_height(item); }
            set
            {
                ValidatePropertyValue(Properties.Height, value);
                flex_item_set_height(item, value);
            }
        }

        public Align JustifyContent
        {
            get { return (Align)flex_item_get_justify_content(item); }
            set
            {
                ValidatePropertyValue(Properties.JustifyContent, (int)value);
                flex_item_set_justify_content(item, (int)value);
            }
        }

        public float Left
        {
            get { return flex_item_get_left(item); }
            set
            {
                ValidatePropertyValue(Properties.Left, value);
                flex_item_set_left(item, value);
            }
        }

        public float MarginBottom
        {
            get { return flex_item_get_margin_bottom(item); }
            set
            {
                ValidatePropertyValue(Properties.MarginBottom, value);
                flex_item_set_margin_bottom(item, value);
            }
        }

        public float MarginLeft
        {
            get { return flex_item_get_margin_left(item); }
            set
            {
                ValidatePropertyValue(Properties.MarginLeft, value);
                flex_item_set_margin_left(item, value);
            }
        }

        public float MarginRight
        {
            get { return flex_item_get_margin_right(item); }
            set
            {
                ValidatePropertyValue(Properties.MarginRight, value);
                flex_item_set_margin_right(item, value);
            }
        }

        public float MarginTop
        {
            get { return flex_item_get_margin_top(item); }
            set
            {
                ValidatePropertyValue(Properties.MarginTop, value);
                flex_item_set_margin_top(item, value);
            }
        }

        public int Order
        {
            get { return flex_item_get_order(item); }
            set
            {
                ValidatePropertyValue(Properties.Order, value);
                flex_item_set_order(item, value);
            }
        }

        public float PaddingBottom
        {
            get { return flex_item_get_padding_bottom(item); }
            set
            {
                ValidatePropertyValue(Properties.PaddingBottom, value);
                flex_item_set_padding_bottom(item, value);
            }
        }

        public float PaddingLeft
        {
            get { return flex_item_get_padding_left(item); }
            set
            {
                ValidatePropertyValue(Properties.PaddingLeft, value);
                flex_item_set_padding_left(item, value);
            }
        }

        public float PaddingRight
        {
            get { return flex_item_get_padding_right(item); }
            set
            {
                ValidatePropertyValue(Properties.PaddingRight, value);
                flex_item_set_padding_right(item, value);
            }
        }

        public float PaddingTop
        {
            get { return flex_item_get_padding_top(item); }
            set
            {
                ValidatePropertyValue(Properties.PaddingTop, value);
                flex_item_set_padding_top(item, value);
            }
        }

        public Position Position
        {
            get { return (Position)flex_item_get_position(item); }
            set
            {
                ValidatePropertyValue(Properties.Position, (int)value);
                flex_item_set_position(item, (int)value);
            }
        }

        public float Right
        {
            get { return flex_item_get_right(item); }
            set
            {
                ValidatePropertyValue(Properties.Right, value);
                flex_item_set_right(item, value);
            }
        }

        public int Shrink
        {
            get { return flex_item_get_shrink(item); }
            set
            {
                ValidatePropertyValue(Properties.Shrink, value);
                flex_item_set_shrink(item, value);
            }
        }

        public float Top
        {
            get { return flex_item_get_top(item); }
            set
            {
                ValidatePropertyValue(Properties.Top, value);
                flex_item_set_top(item, value);
            }
        }

        public float Width
        {
            get { return flex_item_get_width(item); }
            set
            {
                ValidatePropertyValue(Properties.Width, value);
                flex_item_set_width(item, value);
            }
        }

        public Wrap Wrap
        {
            get { return (Wrap)flex_item_get_wrap(item); }
            set
            {
                ValidatePropertyValue(Properties.Wrap, (int)value);
                flex_item_set_wrap(item, (int)value);
            }
        }

        partial void ValidatePropertyValue(Properties property, int value);
        partial void ValidatePropertyValue(Properties property, float value);
    }
}
