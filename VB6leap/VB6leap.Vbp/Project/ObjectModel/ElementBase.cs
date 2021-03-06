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
using System.IO;

namespace VB6leap.Vbp.Project.ObjectModel
{
    /// <summary>
    /// Represents the base type for all elements that can be specified in a VB6 project file.
    /// </summary>
    public abstract class ElementBase
    {
        #region Properties

        /// <summary>
        /// Gets/sets the display name of this element.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets/sets the file path as read from the project file.
        /// See documentation for further information.
        /// </summary>
        /// <remarks>Usually this lies in the same directory as the VBP, but can also be relative to the project directory.</remarks>
        public string FileName { get; set; }

        /// <summary>
        /// Gets the name of the virtual directory the deriving type will be put in.
        /// If this is null, then the file is not visible.
        /// </summary>
        public virtual string ParentDirectoryName
        {
            get { return null; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the absolute path to the underlying file.
        /// </summary>
        /// <param name="project">The <see cref="IVbProject"/> instance used for retrieving the full path (if the file path is relative).</param>
        /// <returns>The absolute path to the underlying file.</returns>
        public string GetAbsoluteFileName(IVbProject project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("project");
            }
            
            if (Path.IsPathRooted(this.FileName))
            {
                return this.FileName;
            }

            return Path.Combine(project.Source.DirectoryName, this.FileName);
        }

        #endregion
    }
}
