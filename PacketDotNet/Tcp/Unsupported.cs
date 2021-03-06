﻿/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace PacketDotNet.Tcp
{
    public class Unsupported : Option
    {
        /// <summary>
        /// Creates an Option that is not yet supported by PacketDotNet.
        /// </summary>
        /// <param name="bytes">A <see cref="T:System.Byte[]" /></param>
        /// <param name="offset">A <see cref="T:System.Int32" /></param>
        /// <param name="length">A <see cref="T:System.Int32" /></param>
        public Unsupported(byte[] bytes, int offset, int length) : base(bytes, offset, length)
        { }

        /// <summary>
        /// Returns the Option info as a string
        /// </summary>
        /// <returns>
        /// A <see cref="string" />
        /// </returns>
        public override string ToString()
        {
            return "[" + Kind + ": Currently unsupported by PacketDotNet]";
        }
    }
}