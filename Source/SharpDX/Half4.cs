﻿// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Defines a four component vector, using half precision floating point coordinates.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
#if !WIN8METRO
    [Serializable]
    [TypeConverter(typeof(SharpDX.Design.Half4Converter))]
#endif
    public struct Half4 : IEquatable<Half4>
    {
        /// <summary>
        /// Gets or sets the X component of the vector.
        /// </summary>
        /// <value>The X component of the vector.</value>
        public Half X;
        /// <summary>
        /// Gets or sets the Y component of the vector.
        /// </summary>
        /// <value>The Y component of the vector.</value>
        public Half Y;
        /// <summary>
        /// Gets or sets the Z component of the vector.
        /// </summary>
        /// <value>The Z component of the vector.</value>
        public Half Z;
        /// <summary>
        /// Gets or sets the W component of the vector.
        /// </summary>
        /// <value>The W component of the vector.</value>
        public Half W;
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Half4" /> structure.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public Half4(Half x, Half y, Half z, Half w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Half4" /> structure.
        /// </summary>
        /// <param name="value">The value to set for the X, Y, Z, and W components.</param>
        public Half4(Half value)
        {
            this.X = value;
            this.Y = value;
            this.Z = value;
            this.W = value;
        }

        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left" /> has the same value as <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Half4 left, Half4 right)
        {
            return Equals(ref left, ref right);
        }

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left" /> has a different value than <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Half4 left, Half4 right)
        {
            return !Equals(ref left, ref right);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int num2 = this.W.GetHashCode() + this.Z.GetHashCode();
            int num = this.Y.GetHashCode() + num2;
            return (this.X.GetHashCode() + num);
        }

        /// <summary>
        /// Determines whether the specified object instances are considered equal. 
        /// </summary>
        /// <param name="value1" />
        /// <param name="value2" />
        /// <returns>
        /// <c>true</c> if <paramref name="value1" /> is the same instance as <paramref name="value2" /> or 
        /// if both are <c>null</c> references or if <c>value1.Equals(value2)</c> returns <c>true</c>; otherwise, <c>false</c>.</returns>
        public static bool Equals(ref Half4 value1, ref Half4 value2)
        {
            return (((value1.X == value2.X) && (value1.Y == value2.Y)) && ((value1.Z == value2.Z) && (value1.W == value2.W)));
        }

        /// <summary>
        /// Returns a value that indicates whether the current instance is equal to the specified object. 
        /// </summary>
        /// <param name="other">Object to make the comparison with.</param>
        /// <returns>
        /// <c>true</c> if the current instance is equal to the specified object; <c>false</c> otherwise.</returns>
        public bool Equals(Half4 other)
        {
            return (((this.X == other.X) && (this.Y == other.Y)) && ((this.Z == other.Z) && (this.W == other.W)));
        }

        /// <summary>
        /// Returns a value that indicates whether the current instance is equal to a specified object. 
        /// </summary>
        /// <param name="obj">Object to make the comparison with.</param>
        /// <returns>
        /// <c>true</c> if the current instance is equal to the specified object; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!ReferenceEquals(obj.GetType(), typeof(Half4)))
            {
                return false;
            }
            return this.Equals((Half4)obj);
        }
    }
}
