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

using System;

namespace VB6leap.Vbp.Serialization
{
    /// <summary>
    /// Represents an exception that is thrown when parsing of a project file has failed.
    /// </summary>
    [Serializable()]
    public class ProjectParseException : Exception
    {
        #region Constructors

        public ProjectParseException()
            : this("Parsing failed!")
        {

        }

        public ProjectParseException(string message)
            : base(message)
        {

        }

        public ProjectParseException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        #endregion
    }
}
