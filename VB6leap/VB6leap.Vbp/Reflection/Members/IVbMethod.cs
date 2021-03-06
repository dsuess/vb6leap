﻿// This file is part of vb6leap.
// 
// vb6leap is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// vb6leap is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with vb6leap.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using VB6leap.Vbp.Reflection.Source;
using VB6leap.Vbp.Reflection.Types;

namespace VB6leap.Vbp.Reflection.Members
{
    /// <summary>
    /// Defines members that represent a VB Classic method.
    /// </summary>
    public interface IVbMethod : IVbMember
    {
        /// <summary>
        /// Gets the kind of this method.
        /// </summary>
        VbMethodType MethodKind { get; }
        /// <summary>
        /// Gets the type the method returns.
        /// </summary>
        IVbType ReturnType { get; }
        /// <summary>
        /// Gets a list of all parameters this method has.
        /// </summary>
        IReadOnlyList<IVbParameter> Parameters { get; }
        /// <summary>
        /// Gets the location of the final, closing "End" statement.
        /// This is where the method body ends.
        /// </summary>
        ISourceLocation EndStatementLocation { get; }
    }
}
