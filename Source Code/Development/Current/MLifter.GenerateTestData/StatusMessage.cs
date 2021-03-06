/***************************************************************************************************************************************
 * Copyright (C) 2001-2012 LearnLift USA																	*
 * Contact: Learnlift USA, 12 Greenway Plaza, Suite 1510, Houston, Texas 77046, support@memorylifter.com					*
 *																								*
 * This library is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License	*
 * as published by the Free Software Foundation; either version 2.1 of the License, or (at your option) any later version.			*
 *																								*
 * This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty	*
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.	*
 *																								*
 * You should have received a copy of the GNU Lesser General Public License along with this library; if not,					*
 * write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA					*
 ***************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace MLifter.GenerateTestData.BL
{
    /// <summary>
    /// Event handler used to report status message.
    /// </summary>
    public delegate void TestStatusEventHandler(object sender, TestStatusEventArgs args);

    /// <summary>
    /// Event args used to send progress updates.
    /// </summary>
    /// <remarks>Documented by Dev03, 2008-08-21</remarks>
    public class TestStatusEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusMessageEventArgs"/> class.
        /// </summary>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public TestStatusEventArgs()
        {
            m_Progress = 0;
            m_MaximumProgress = 100;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusMessageEventArgs"/> class.
        /// </summary>
        /// <param name="maximumProgress">The maximum value for progress.</param>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public TestStatusEventArgs(int maximumProgress)
        {
            m_Progress = 0;
            m_MaximumProgress = maximumProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusMessageEventArgs"/> class.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <param name="maximumProgress">The maximum progress.</param>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public TestStatusEventArgs(int progress, int maximumProgress)
        {
            m_Progress = progress;
            m_MaximumProgress = maximumProgress;
        }

        private object m_UserState = null;
        private int m_Progress;
        private int m_MaximumProgress;

        /// <summary>
        /// Gets or sets the progress value.
        /// </summary>
        /// <value>The progress value.</value>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public int Progress
        {
            get { return m_Progress; }
            set { m_Progress = value; }
        }

        /// <summary>
        /// Gets the progress percentage.
        /// </summary>
        /// <value>The progress percentage.</value>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public int ProgressPercentage
        {
            get 
            {
                return Convert.ToInt32(((m_Progress * 1.0) / (m_MaximumProgress * 1.0) * 100));
            }
        }

        /// <summary>
        /// Gets or sets a unique user state.
        /// </summary>
        /// <value>The user state.</value>
        /// <remarks>Documented by Dev03, 2008-08-21</remarks>
        public object UserState
        {
            get { return m_UserState; }
            set { m_UserState = value; }
        }

    }
}
