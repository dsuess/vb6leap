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
using ICSharpCode.SharpDevelop.Gui;
using VB6leap.Vbp.Project;

namespace VB6leap.SD.Options
{
    /// <summary>
    /// Interaction logic for VB6leapProjectOptionsPanel.xaml
    /// </summary>
    public partial class VB6leapProjectOptionsPanel : OptionPanel
    {
        #region Fields

        private IVbpProject _project;
        private ViewModel _viewModel;
        
        #endregion

        #region Constructors

        public VB6leapProjectOptionsPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public override void LoadOptions()
        {
            _project = (IVbpProject)this.Owner;

            _viewModel = new ViewModel(_project.GetOwnedProject());
            this.DataContext = _viewModel;

            base.LoadOptions();
        }

        public override bool SaveOptions()
        {
            return base.SaveOptions();
        }

        #endregion

        #region Nested types

        class ViewModel
        {
            #region Fields

            private IVbProject _project;

            #endregion

            #region Properties

            public string Type
            {
                get { return _project.Type.ToString(); }
            }

            public string Name
            {
                get { return _project.Properties.Name; }
                set { _project.Properties.Name = value; }
            }

            public string Title
            {
                get { return _project.Properties.Title; }
                set { _project.Properties.Title = value; }
            }

            public string Version
            {
                get { return _project.Properties.Version.ToString(3); }
                set { _project.Properties.Version = new Version(value); }
            }

            public bool AutoIncrementVer
            {
                get { return _project.Properties.Get("AutoIncrementVer", "0") == "1"; }
            }

            public string Startup
            {
                get { return _project.Properties.Startup; }
                set { _project.Properties.Startup = value; }
            }

            #endregion

            #region Constructors

            public ViewModel(IVbProject project)
            {
                _project = project;
            }

            #endregion

        }

        #endregion
    }
}
