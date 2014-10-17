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
using ICSharpCode.SharpDevelop.Project;

namespace VB6leap.SD
{
    public class VbpProjectBinding : IProjectBinding
    {
        #region Constants

        public const string LanguageName = "VB6";

        #endregion

        #region Constructors

        public VbpProjectBinding()
        {
        }

        #endregion

        #region IProjectBinding implementation

        IProject IProjectBinding.LoadProject(ProjectLoadInformation info)
        {
            return new VbpProject(info);
        }

        IProject IProjectBinding.CreateProject(ProjectCreateInformation info)
        {
            // TODO: VBP creation currently not supported.
            throw new NotSupportedException("VBP creation is currently not supported.");
        }

        bool IProjectBinding.HandlingMissingProject
        {
            get
            {
                return false;
            }
        }

        #endregion
    }
}